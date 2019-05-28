using Aeroportos.Application.Dtos.Base;

namespace Aeroportos.Application.Dtos
{
    public class TipoAeroportoDto : BaseEntityDto
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }
    }
}