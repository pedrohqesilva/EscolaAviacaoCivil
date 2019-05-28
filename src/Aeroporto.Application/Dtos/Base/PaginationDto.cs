namespace Aeroportos.Application.Dtos.Base
{
    public class PaginationDto
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public string Order { get; set; }
        public string SortOrder { get; set; } = "ASC";
        public int Skip { get; set; }
        public int Take { get; set; }

        public void TotalPagesCalculate()
        {
            if (Page == 0 || TotalItems == 0 || PageSize == 0)
            {
                TotalPages = 1;
                return;
            }

            int totalPages;

            int mod = TotalItems % PageSize;
            totalPages = TotalItems / PageSize;

            TotalPages = (mod > 0) ? ++totalPages : totalPages;
        }
    }
}