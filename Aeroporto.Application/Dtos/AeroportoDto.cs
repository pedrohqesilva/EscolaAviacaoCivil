using Aeroportos.Application.Dtos.Base;
using Core.Domain.Entities;

namespace Aeroportos.Application.Dtos
{
    public class AeroportoDto : BaseEntity
    {
        public PaginationDto Pagination { get; set; }

        public string CodigoIcao { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public TipoAeroportoDto TipoAeroporto { get; private set; }
        public EnderecoDto Endereco { get; private set; }
    }
}