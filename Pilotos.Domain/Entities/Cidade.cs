using System.Collections.Generic;
using Core.Domain.Entities;

namespace Pilotos.Domain.Entities
{
    public class Cidade : BaseEntity
    {
        #region Properties

        public string Sigla { get; private set; }
        public string Descricao { get; private set; }
        public int EstadoId { get; private set; }
        public virtual Estado Estado { get; private set; }
        public virtual IList<Endereco> Enderecos { get; set; }

        #endregion Properties

        #region Constructors

        public Cidade(string sigla, string descricao, int estadoId)
        {
            Sigla = sigla;
            Descricao = descricao;
            EstadoId = estadoId;
        }

        #endregion Constructors

        #region Update

        public void Update(string sigla, string descricao, int estadoId)
        {
            this
                .UpdateSigla(sigla)
                .UpdateDescricao(descricao)
                .UpdateEstado(estadoId);
        }

        public Cidade UpdateSigla(string sigla)
        {
            Sigla = sigla;
            return this;
        }

        public Cidade UpdateDescricao(string descricao)
        {
            Descricao = descricao;
            return this;
        }

        public Cidade UpdateEstado(int estadoId)
        {
            EstadoId = estadoId;
            return this;
        }

        #endregion Update
    }
}