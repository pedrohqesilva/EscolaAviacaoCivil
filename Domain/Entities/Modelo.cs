using Domain.Entities.Base;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Modelo : BaseEntity
    {
        public string Descricao { get; set; }
        public int FabricanteId { get; set; }
        public virtual Fabricante Fabricante { get; set; }
        public virtual IList<Aviao> Avioes { get; set; }

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