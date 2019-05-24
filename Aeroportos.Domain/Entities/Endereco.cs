using System.Collections.Generic;
using Core.Domain.Entities;

namespace Aeroportos.Domain.Entities
{
    public class Endereco : BaseEntity
    {
        #region Properties

        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public int Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public int CidadeId { get; private set; }
        public virtual Cidade Cidade { get; private set; }
        public int AeroportoId { get; }
        public virtual Aeroporto Aeroporto { get; private set; }

        #endregion Properties

        #region Constructors

        public Endereco(string cep, string logradouro, int numero, string complemento, string bairro, int cidadeId, int aeroportoId)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CidadeId = cidadeId;
            AeroportoId = aeroportoId;
        }

        #endregion Constructors

        #region Update

        public void Update(string cep, string logradouro, int numero, string complemento, string bairro, int cidadeId)
        {
            this
                .UpdateCep(cep)
                .UpdateLogradouro(logradouro)
                .UpdateNumero(numero)
                .UpdateComplemento(complemento)
                .UpdateBairro(bairro)
                .UpdateCidade(cidadeId);
        }

        public Endereco UpdateCep(string cep)
        {
            Cep = cep;
            return this;
        }

        public Endereco UpdateLogradouro(string logradouro)
        {
            Logradouro = logradouro;
            return this;
        }

        public Endereco UpdateNumero(int numero)
        {
            Numero = numero;
            return this;
        }

        public Endereco UpdateComplemento(string complemento)
        {
            Complemento = complemento;
            return this;
        }

        public Endereco UpdateBairro(string bairro)
        {
            Bairro = bairro;
            return this;
        }

        public Endereco UpdateCidade(int cidadeId)
        {
            CidadeId = cidadeId;
            return this;
        }

        #endregion Update
    }
}