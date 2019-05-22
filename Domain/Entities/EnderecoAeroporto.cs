using Domain.Entities.Base;

namespace Domain.Entities
{
    public class EnderecoAeroporto : BaseEntity
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public int AeroportoId { get; set; }
        public virtual Aeroporto Aeroporto { get; set; }

        private EnderecoAeroporto() => Metadata.Create();

        public static EnderecoAeroporto Create(string cep, string logradouro, int numero, string complemento, string bairro, int cidadeId, int estadoId, int aeroportoId)
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
                EstadoId = estadoId,
                AeroportoId = aeroportoId
            };
        }

        public EnderecoAeroporto Update(string cep, string logradouro, int numero, string complemento, string bairro, int cidadeId, int estadoId)
        {
            // Adicionar validator

            this
                .UpdateCep(cep)
                .UpdateLogradouro(logradouro)
                .UpdateNumero(numero)
                .UpdateComplemento(complemento)
                .UpdateBairro(bairro)
                .UpdateCidade(cidadeId)
                .UpdateEstado(estadoId);

            return this;
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

        public EnderecoAeroporto UpdateEstado(int estadoId)
        {
            Metadata.Update();
            EstadoId = estadoId;
            return this;
        }
    }
}