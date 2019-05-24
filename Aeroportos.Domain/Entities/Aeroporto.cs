using Core.Domain.Entities;

namespace Aeroportos.Domain.Entities
{
    public class Aeroporto : BaseEntity
    {
        #region Properties

        public string CodigoIcao { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public int TipoAeroportoId { get; private set; }
        public virtual TipoAeroporto TipoAeroporto { get; private set; }
        public int CidadeId { get; private set; }
        public virtual Cidade Cidade { get; private set; }

        #endregion Properties

        #region Constructors

        public Aeroporto(string codigoIcao, string nome, string descricao, int tipoAeroportoId, int cidadeId)
        {
            CodigoIcao = codigoIcao;
            Nome = nome;
            Descricao = descricao;
            TipoAeroportoId = tipoAeroportoId;
            CidadeId = cidadeId;
        }

        #endregion Constructors

        #region Update

        public void Update(string codigoIcao, string nome, string descricao)
        {
            this
                .UpdateCodigoIcao(codigoIcao)
                .UpdateNome(nome)
                .UpdateDescricao(descricao);
        }

        public Aeroporto UpdateCodigoIcao(string codigoIcao)
        {
            CodigoIcao = codigoIcao;
            return this;
        }

        public Aeroporto UpdateNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public Aeroporto UpdateDescricao(string descricao)
        {
            Descricao = descricao;
            return this;
        }

        public Aeroporto UpdateTipoAeroporto(int tipoAeroportoId)
        {
            TipoAeroportoId = tipoAeroportoId;
            return this;
        }

        public Aeroporto UpdateCidade(int cidadeId)
        {
            CidadeId = cidadeId;
            return this;
        }

        #endregion Update
    }
}