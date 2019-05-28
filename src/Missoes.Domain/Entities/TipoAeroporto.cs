using Core.Domain.Entities;

namespace Missoes.Domain.Entities
{
    public class TipoAeroporto : BaseEntity
    {
        public string Sigla { get; private set; }
        public string Descricao { get; private set; }

        public TipoAeroporto(string sigla, string descricao)
        {
            Sigla = sigla;
            Descricao = descricao;
        }
    }
}