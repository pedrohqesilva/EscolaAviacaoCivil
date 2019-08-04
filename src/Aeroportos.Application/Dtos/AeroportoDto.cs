using Core.Domain.Entities;

namespace Aeroportos.Application.Dtos
{
    public class AeroportoDto : BaseEntity
    {
        public string CodigoIcao { get; private set; }
        public string CodigoIata { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public TipoAeroportoDto TipoAeroporto { get; private set; }
        public EnderecoDto Endereco { get; private set; }
    }
}