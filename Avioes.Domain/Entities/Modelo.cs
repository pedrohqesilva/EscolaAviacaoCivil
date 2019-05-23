using Core.Domain.Entities;
using System.Collections.Generic;

namespace Avioes.Domain.Entities
{
    public class Modelo : BaseEntity
    {
        public string Abreviacao { get; private set; }
        public string Descricao { get; private set; }
        public string Observacao { get; private set; }
        public int FabricanteId { get; private set; }
        public virtual Fabricante Fabricante { get; private set; }
        public virtual IList<Aviao> Avioes { get; private set; }

        public Modelo(string abreviacao, string descricao, string observacao, int fabricanteId)
        {
            Abreviacao = abreviacao;
            Descricao = descricao;
            Observacao = observacao;
            FabricanteId = fabricanteId;
        }

        public Modelo UpdateDescricao(string descricao)
        {
            Descricao = descricao;
            return this;
        }

        public Modelo UpdateFabricante(int fabricanteId)
        {
            FabricanteId = fabricanteId;
            return this;
        }
    }
}