using Core.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Missoes.Domain.Entities
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
        public IList<Endereco> Enderecos { get; private set; }
        public IList<Telefone> Telefones { get; private set; }
        public IList<Email> Emails { get; private set; }

        public Piloto(string nome, string cpf, DateTime dataNascimento, string formacaoAcademica,
            string observacao, string sexo, int carteiraAnacId)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            FormacaoAcademica = formacaoAcademica;
            Observacao = observacao;
            Sexo = sexo;
            CarteiraAnacId = carteiraAnacId;
        }
    }
}