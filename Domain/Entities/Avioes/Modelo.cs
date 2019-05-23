using Domain.Entities.Base;
using System.Collections.Generic;

namespace Domain.Entities.Avioes
{
    public class Modelo : BaseEntity
    {
        public string Abreviacao { get; private set; }
        public string Descricao { get; private set; }
        public string Observacao { get; private set; }
        public int FabricanteId { get; private set; }
        public virtual Fabricante Fabricante { get; private set; }
        public virtual IList<Aviao> Avioes { get; private set; }

        private Modelo() => Metadata.Create();

        public static Modelo Create(string descricao, int fabricanteId)
        {
            return new Modelo
            {
                Descricao = descricao,
                FabricanteId = fabricanteId
            };
        }

        public Modelo UpdateDescricao(string descricao)
        {
            Metadata.Update();
            Descricao = descricao;
            return this;
        }

        public Modelo UpdateFabricante(int fabricanteId)
        {
            Metadata.Update();
            FabricanteId = fabricanteId;
            return this;
        }
    }
}