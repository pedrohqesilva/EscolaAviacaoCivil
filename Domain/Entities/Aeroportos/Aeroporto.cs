using Domain.Entities.Base;

namespace Domain.Entities.Aeroportos
{
    public class Aeroporto : BaseEntity
    {
        public string CodigoIcao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int TipoAeroportoId { get; set; }
        public TipoAeroporto TipoAeroporto { get; set; }
        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }

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