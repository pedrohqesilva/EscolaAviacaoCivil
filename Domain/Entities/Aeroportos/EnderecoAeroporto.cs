using Domain.Entities.Base;

namespace Domain.Entities.Aeroportos
{
    public class EnderecoAeroporto : BaseEntity
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

        private EnderecoAeroporto() => Metadata.Create();

        public static EnderecoAeroporto Create(string cep, string logradouro, int numero, string complemento, string bairro, int cidadeId, int aeroportoId)
        {
            // Adicionar validator

            return new EnderecoAeroporto
            {
                Cep = cep,
                Logradouro = logradouro,
                Numero = numero,
                Complemento = complemento,
                Bairro = bairro,
                CidadeId = cidadeId,
                AeroportoId = aeroportoId
            };
        }

        public void Update(string cep, string logradouro, int numero, string complemento, string bairro, int cidadeId)
        {
            // Adicionar validator

            this
                .UpdateCep(cep)
                .UpdateLogradouro(logradouro)
                .UpdateNumero(numero)
                .UpdateComplemento(complemento)
                .UpdateBairro(bairro)
                .UpdateCidade(cidadeId);
        }

        public EnderecoAeroporto UpdateCep(string cep)
        {
            Metadata.Update();
            Cep = cep;
            return this;
        }

        public EnderecoAeroporto UpdateLogradouro(string logradouro)
        {
            Metadata.Update();
            Logradouro = logradouro;
            return this;
        }

        public EnderecoAeroporto UpdateNumero(int numero)
        {
            Metadata.Update();
            Numero = numero;
            return this;
        }

        public EnderecoAeroporto UpdateComplemento(string complemento)
        {
            Metadata.Update();
            Complemento = complemento;
            return this;
        }

        public EnderecoAeroporto UpdateBairro(string bairro)
        {
            Metadata.Update();
            Bairro = bairro;
            return this;
        }

        public EnderecoAeroporto UpdateCidade(int cidadeId)
        {
            Metadata.Update();
            CidadeId = cidadeId;
            return this;
        }
    }
}