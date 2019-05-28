namespace Application.Dto.Comum
{

    public class PaginacaoDto
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
            if (this.Page == 0 || this.TotalItems == 0 || this.PageSize == 0)
            {
                this.TotalPages = 1;
                return;
            }

            int totalPaginas;

            int mod = this.TotalItems % this.PageSize;
            totalPaginas = this.TotalItems / this.PageSize;

            this.TotalPages = (mod > 0) ?
                ++totalPaginas
                : totalPaginas;

        }

    }
}
