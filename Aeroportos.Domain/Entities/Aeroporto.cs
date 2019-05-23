using Core.Domain.Entities;

namespace Aeroportos.Domain.Entities
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

        public Aeroporto(string codigoIcao, string nome, string descricao, int tipoAeroportoId, int cidadeId)
        {
            CodigoIcao = codigoIcao;
            Nome = nome;
            Descricao = descricao;
            TipoAeroportoId = tipoAeroportoId;
            CidadeId = cidadeId;
        }
    }
}