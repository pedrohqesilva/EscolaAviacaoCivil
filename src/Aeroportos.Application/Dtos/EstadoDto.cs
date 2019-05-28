using Aeroportos.Application.Dtos.Base;

namespace Aeroportos.Application.Dtos
{
    public class EstadoDto : BaseEntityDto
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public PaisDto Pais { get; set; }
    }
}