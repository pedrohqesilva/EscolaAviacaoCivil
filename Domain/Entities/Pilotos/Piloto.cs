using Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Pilotos
{
    public class Piloto : BaseEntity
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string FormacaoAcademica { get; private set; }
        public string Observacao { get; private set; }
        public string Sexo { get; private set; }
        public int CarteiraAnacId { get; private set; }
        public CarteiraAnac CarteiraAnac { get; private set; }
        public int CarteiraIdentidadeId { get; private set; }
        public CarteiraIdentidade CarteiraIdentidade { get; private set; }
        public int CarteiraHabilitacaoId { get; private set; }
        public CarteiraHabilitacao CarteiraHabilitacao { get; private set; }
        public IList<EnderecoPiloto> Enderecos { get; private set; }
        public IList<TelefonePiloto> Telefones { get; private set; }
        public IList<EmailPiloto> Emails { get; private set; }

        private Piloto() => Metadata.Create();
    }
}