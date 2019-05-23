using Domain.Entities.Base;

namespace Domain.Entities.Aeroportos
{
    public class Aeroporto : BaseEntity
    {
        public string CodigoIcao { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public int TipoAeroportoId { get; private set; }
        public TipoAeroporto TipoAeroporto { get; private set; }
        public int CidadeId { get; private set; }
        public Cidade Cidade { get; private set; }

        private Aeroporto() => Metadata.Create();

        public static Aeroporto Create(string codigoIcao)
        {
            return new Aeroporto
            {
                CodigoIcao = codigoIcao
            };
        }
    }
}