using Core.Domain.Entities;

namespace Pilotos.Domain.Entities
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
        public int PilotoId { get; private set; }
        public virtual Piloto Piloto { get; private set; }

        #endregion Properties

        #region Constructors

        public Endereco(string cep, string logradouro, int numero, string complemento,
            string bairro, int cidadeId, int pilotoId)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CidadeId = cidadeId;
            PilotoId = pilotoId;
        }

        #endregion Constructors

        #region Update

        public void Update(string cep, string logradouro, int numero,
            string complemento, string bairro)
        {
            UpdateCep(cep)
            .UpdateLogradouro(logradouro)
            .UpdateNumero(numero)
            .UpdateComplemento(complemento)
            .UpdateBairro(bairro);
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

        public Endereco UpdatePiloto(int pilotoId)
        {
            PilotoId = pilotoId;
            return this;
        }

        #endregion Update
    }
}