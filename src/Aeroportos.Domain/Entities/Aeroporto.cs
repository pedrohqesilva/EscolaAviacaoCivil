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
        public int EnderecoId { get; private set; }
        public virtual Endereco Endereco { get; private set; }

        #endregion Properties

        #region Constructors

        public Aeroporto(string codigoIcao, string nome, string descricao, int enderecoId, int tipoAeroportoId)
        {
            CodigoIcao = codigoIcao;
            Nome = nome;
            Descricao = descricao;
            EnderecoId = enderecoId;
            TipoAeroportoId = tipoAeroportoId;
        }

        #endregion Constructors

        #region Update

        public void Update(string nome, string descricao)
        {
            UpdateNome(nome)
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

        public Aeroporto UpdateEndereco(int enderecoId)
        {
            EnderecoId = enderecoId;
            return this;
        }

        public Aeroporto UpdateTipoAeroporto(int tipoAeroportoId)
        {
            TipoAeroportoId = tipoAeroportoId;
            return this;
        }

        #endregion Update
    }
}