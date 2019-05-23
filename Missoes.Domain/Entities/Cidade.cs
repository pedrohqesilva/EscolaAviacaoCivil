using Core.Domain.Entities;

namespace Missoes.Domain.Entities
{
    public class Cidade : BaseEntity
    {
        public string Sigla { get; private set; }
        public string Descricao { get; private set; }
        public int EstadoId { get; private set; }
        public Estado Estado { get; private set; }

        public Cidade(string sigla, string descricao, int estadoId)
        {
            Sigla = sigla;
            Descricao = descricao;
            EstadoId = estadoId;
        }
    }
}