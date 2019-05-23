using Core.Domain.Entities;

namespace Aeroportos.Domain.Entities
{
    public class Pais : BaseEntity
    {
        public string Sigla { get; private set; }
        public string Descricao { get; private set; }

        public Pais(string sigla, string descricao)
        {
            Sigla = sigla;
            Descricao = descricao;
        }
    }
}