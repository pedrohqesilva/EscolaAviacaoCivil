using Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Pilotos
{
    public class Piloto : BaseEntity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string FormacaoAcademica { get; set; }
        public string Observacao { get; set; }
        public string Sexo { get; set; }
        public int CarteiraAnacId { get; set; }
        public CarteiraAnac CarteiraAnac { get; set; }
        public int CarteiraIdentidadeId { get; set; }
        public CarteiraIdentidade CarteiraIdentidade { get; set; }
        public int CarteiraHabilitacaoId { get; set; }
        public CarteiraHabilitacao CarteiraHabilitacao { get; set; }
        public IList<EnderecoPiloto> Enderecos { get; set; }
        public IList<TelefonePiloto> Telefones { get; set; }
        public IList<EmailPiloto> Emails { get; set; }

        private Piloto() => Metadata.Create();
    }
}