using Core.Domain.Entities;
using System.Collections.Generic;

namespace Avioes.Domain.Entities
{
    public class Fabricante : BaseEntity
    {
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Descricao { get; private set; }
        public virtual IList<Modelo> Modelos { get; private set; }

        public Fabricante(string razaoSocial, string nomeFantasia, string descricao)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Descricao = descricao;
        }

        public Fabricante UpdateDescricao(string descricao)
        {
            Descricao = descricao;
            return this;
        }
    }
}