using Core.Domain.Entities;
using System.Collections.Generic;

namespace Aeroportos.Domain.Entities
{
    public class TipoAeroporto : BaseEntity
    {
        public string Sigla { get; private set; }
        public string Descricao { get; private set; }
        public virtual IList<Aeroporto> Aeroportos { get; private set; }

        public TipoAeroporto(int id, string sigla, string descricao)
        {
            Id = id;
            Sigla = sigla;
            Descricao = descricao;
        }
    }
}