using Aeroportos.Application.Dtos.Base;

namespace Aeroportos.Application.Dtos
{
    public class AeroportoFiltroDto
    {
        public PaginationDto Pagination { get; set; }

        public int TipoAeroportoId { get; set; }
    }
}