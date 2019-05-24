using Core.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Pilotos.Domain.Entities
{
    public class Piloto : BaseEntity
    {
        #region Properties

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string FormacaoAcademica { get; private set; }
        public string Observacao { get; private set; }
        public string Sexo { get; private set; }
        public int CarteiraAnacId { get; private set; }
        public virtual CarteiraAnac CarteiraAnac { get; private set; }
        public virtual IList<Endereco> Enderecos { get; private set; }
        public virtual IList<Telefone> Telefones { get; private set; }
        public virtual IList<Email> Emails { get; private set; }

        #endregion Properties

        #region Constructors

        public Piloto(string nome, string cpf, DateTime dataNascimento, string formacaoAcademica, string observacao, string sexo, int carteiraAnacId)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            FormacaoAcademica = formacaoAcademica;
            Observacao = observacao;
            Sexo = sexo;
            CarteiraAnacId = carteiraAnacId;
        }

        #endregion Constructors

        #region Update

        public void Update(string nome, string cpf, DateTime dataNascimento, string formacaoAcademica, string observacao, string sexo)
        {
            this
                .UpdateNome(nome)
                .UpdateCpf(cpf)
                .UpdateDataNascimento(dataNascimento)
                .UpdateFormacaoAcademica(formacaoAcademica)
                .UpdateObservacao(observacao)
                .UpdateSexo(sexo);
        }

        public Piloto UpdateNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public Piloto UpdateCpf(string cpf)
        {
            Cpf = cpf;
            return this;
        }

        public Piloto UpdateDataNascimento(DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
            return this;
        }

        public Piloto UpdateFormacaoAcademica(string formacaoAcademica)
        {
            FormacaoAcademica = formacaoAcademica;
            return this;
        }

        public Piloto UpdateObservacao(string observacao)
        {
            Observacao = observacao;
            return this;
        }

        public Piloto UpdateSexo(string sexo)
        {
            Sexo = sexo;
            return this;
        }

        public Piloto UpdateCarteiraAnac(int carteiraAnacId)
        {
            CarteiraAnacId = carteiraAnacId;
            return this;
        }

        #endregion Update
    }
}