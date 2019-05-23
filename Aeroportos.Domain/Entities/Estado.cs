using Core.Domain.Entities;

namespace Aeroportos.Domain.Entities
{
    public class Estado : BaseEntity
    {
        public string Sigla { get; private set; }
        public string Descricao { get; private set; }
        public int PaisId { get; private set; }
        public Pais Pais { get; private set; }

        public Estado(string sigla, string descricao, int paisId)
        {
            Sigla = sigla;
            Descricao = descricao;
            PaisId = paisId;
        }
    }
}