using Core.Domain.Entities;
using System.Collections.Generic;

namespace Avioes.Domain.Entities
{
    public class Fabricante : BaseEntity
    {
        #region Properties

        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Descricao { get; private set; }
        public virtual IList<Modelo> Modelos { get; private set; }

        #endregion Properties

        #region Constructors

        public Fabricante(string razaoSocial, string nomeFantasia, string descricao)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Descricao = descricao;
        }

        #endregion Constructors

        #region Update

        public void Update(string razaoSocial, string nomeFantasia, string descricao)
        {
            UpdateRazaoSocial(razaoSocial)
            .UpdateNomeFantasia(nomeFantasia)
            .UpdateDescricao(descricao);
        }

        public Fabricante UpdateRazaoSocial(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public Fabricante UpdateNomeFantasia(string nomeFantasia)
        {
            NomeFantasia = nomeFantasia;
            return this;
        }

        public Fabricante UpdateDescricao(string descricao)
        {
            Descricao = descricao;
            return this;
        }

        #endregion Update
    }
}