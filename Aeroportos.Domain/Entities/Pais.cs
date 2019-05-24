using Core.Domain.Entities;

namespace Aeroportos.Domain.Entities
{
    public class Pais : BaseEntity
    {
        #region Properties

        public string Sigla { get; private set; }
        public string Descricao { get; private set; }

        #endregion Properties

        #region Constructors

        public Pais(string sigla, string descricao)
        {
            Sigla = sigla;
            Descricao = descricao;
        }

        #endregion Constructors

        #region Update

        public void Update(string sigla, string descricao)
        {
            this
                .UpdateSigla(sigla)
                .UpdateDescricao(descricao);
        }

        public Pais UpdateSigla(string sigla)
        {
            Sigla = sigla;
            return this;
        }

        public Pais UpdateDescricao(string descricao)
        {
            Descricao = descricao;
            return this;
        }

        #endregion Update
    }
}