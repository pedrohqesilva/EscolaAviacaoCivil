using Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Piloto : BaseEntity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public IList<EnderecoPiloto> Enderecos { get; set; }
        public IList<TelefonePiloto> Telefones { get; set; }

        private Piloto() => Metadata.Create();
    }
}
