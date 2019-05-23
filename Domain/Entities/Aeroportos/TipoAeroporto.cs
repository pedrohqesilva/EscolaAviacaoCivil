using Domain.Entities.Base;

namespace Domain.Entities.Aeroportos
{
    public class TipoAeroporto : BaseEntity
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }

        private TipoAeroporto() => Metadata.Create();

        public static TipoAeroporto Create(string sigla, string descricao)
        {
            return new TipoAeroporto
            {
                Sigla = sigla,
                Descricao = descricao
            };
        }
    }
}