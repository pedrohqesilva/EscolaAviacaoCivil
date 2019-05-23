using Domain.Entities.Base;

namespace Domain.Entities.Aeroportos
{
    public class TipoAeroporto : BaseEntity
    {
        public string Sigla { get; private set; }
        public string Descricao { get; private set; }

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