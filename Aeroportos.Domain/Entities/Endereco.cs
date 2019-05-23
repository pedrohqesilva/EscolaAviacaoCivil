using Core.Domain.Entities;

namespace Aeroportos.Domain.Entities
{
    public class Endereco : BaseEntity
    {
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public int Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public int CidadeId { get; private set; }
        public virtual Cidade Cidade { get; private set; }
        public int AeroportoId { get; private set; }
        public virtual Aeroporto Aeroporto { get; private set; }

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
            Metadata.Update();
            Cep = cep;
            return this;
        }

        public Endereco UpdateLogradouro(string logradouro)
        {
            Metadata.Update();
            Logradouro = logradouro;
            return this;
        }

        public Endereco UpdateNumero(int numero)
        {
            Metadata.Update();
            Numero = numero;
            return this;
        }

        public Endereco UpdateComplemento(string complemento)
        {
            Metadata.Update();
            Complemento = complemento;
            return this;
        }

        public Endereco UpdateBairro(string bairro)
        {
            Metadata.Update();
            Bairro = bairro;
            return this;
        }

        public Endereco UpdateCidade(int cidadeId)
        {
            Metadata.Update();
            CidadeId = cidadeId;
            return this;
        }
    }
}