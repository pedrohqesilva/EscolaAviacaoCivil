using Domain.Entities.Base;

namespace Domain.Entities.Pilotos
{
    public class EnderecoPiloto : BaseEntity
    {
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public int Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public int CidadeId { get; private set; }
        public virtual Cidade Cidade { get; private set; }
        public int PilotoId { get; private set; }
        public virtual Piloto Piloto { get; private set; }

        private EnderecoPiloto() => Metadata.Create();

        public static EnderecoPiloto Create(string cep, string logradouro, int numero, string complemento, string bairro, int cidadeId, int pilotoId)
        {
            // Adicionar validator

            return new EnderecoPiloto
            {
                Cep = cep,
                Logradouro = logradouro,
                Numero = numero,
                Complemento = complemento,
                Bairro = bairro,
                CidadeId = cidadeId,
                PilotoId = pilotoId
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

        public EnderecoPiloto UpdateCep(string cep)
        {
            Metadata.Update();
            Cep = cep;
            return this;
        }

        public EnderecoPiloto UpdateLogradouro(string logradouro)
        {
            Metadata.Update();
            Logradouro = logradouro;
            return this;
        }

        public EnderecoPiloto UpdateNumero(int numero)
        {
            Metadata.Update();
            Numero = numero;
            return this;
        }

        public EnderecoPiloto UpdateComplemento(string complemento)
        {
            Metadata.Update();
            Complemento = complemento;
            return this;
        }

        public EnderecoPiloto UpdateBairro(string bairro)
        {
            Metadata.Update();
            Bairro = bairro;
            return this;
        }

        public EnderecoPiloto UpdateCidade(int cidadeId)
        {
            Metadata.Update();
            CidadeId = cidadeId;
            return this;
        }
    }
}