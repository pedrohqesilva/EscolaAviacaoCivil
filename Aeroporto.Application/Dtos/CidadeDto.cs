using Aeroportos.Application.Dtos.Base;

namespace Aeroportos.Application.Dtos
{
    public class CidadeDto : BaseEntityDto
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public EstadoDto Estado { get; set; }
    }
}