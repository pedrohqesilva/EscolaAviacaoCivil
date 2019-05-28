using Aeroportos.Application.Dtos.Base;

namespace Aeroportos.Application.Dtos
{
    public class PaisDto : BaseEntityDto
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }
    }
}