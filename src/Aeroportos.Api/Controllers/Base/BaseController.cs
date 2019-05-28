using Aeroportos.Application.Dtos.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace Aeroportos.Api.Controllers.Base
{
    public class BaseController : Controller
    {
        public PaginationDto Pagination { get; set; }

        public BaseController()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            SetPagination();
        }

        protected string GetHeaderValue(string key)
        {
            if (string.IsNullOrEmpty(key))
                return string.Empty;

            var value = string.Empty;

            if (Request.Headers.TryGetValue(key, out var headerValues))
                value = headerValues;

            return string.IsNullOrEmpty(value) ? string.Empty : value;
        }

        private void AddResponseHeaderValue(string key, string value)
        {
            HttpContext.Response.Headers.Add(key, value);
        }

        private void SetPagination()
        {
            Pagination = GetPaginationHeaderInfo(false);
        }

        protected PaginationDto GetPaginationHeaderInfo(bool canPaginateReturnAllRecords = true)
        {
            var json = GetHeaderValue("Pagination");
            var pagination = JsonConvert.DeserializeObject<PaginationDto>(json);

            pagination = pagination ?? new PaginationDto();

            if (canPaginateReturnAllRecords)
                return pagination;

            if (pagination.Page == 0)
                pagination.Page = 1;

            if (pagination.PageSize == 0)
                pagination.PageSize = 10;

            return pagination;
        }

        protected void SetPaginationHeaderInfo(PaginationDto pagination)
        {
            var header = new
            {
                page = pagination.Page.ToString(),
                pageSize = pagination.PageSize.ToString(),
                totalItems = pagination.TotalItems.ToString(),
                totalPages = pagination.TotalPages.ToString(),
                order = pagination.Order,
                sortOrder = pagination.SortOrder,
            };

            AddResponseHeaderValue("Pagination", JsonConvert.SerializeObject(header));
        }
    }
}