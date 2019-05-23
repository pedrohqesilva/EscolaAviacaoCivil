using Domain.Entities.Base;
using System.Collections.Generic;

namespace Domain.Entities.Avioes
{
    public class Fabricante : BaseEntity
    {
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Descricao { get; private set; }
        public virtual IList<Modelo> Modelos { get; private set; }

        private Fabricante() => Metadata.Create();

        public static Fabricante Create(string descricao)
        {
            return new Fabricante
            {
                Descricao = descricao
            };
        }

        public Fabricante UpdateDescricao(string descricao)
        {
            Metadata.Update();
            Descricao = descricao;
            return this;
        }
    }
}