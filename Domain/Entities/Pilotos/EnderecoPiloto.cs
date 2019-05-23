using Domain.Entities.Base;

namespace Domain.Entities.Pilotos
{
    public class EnderecoPiloto : BaseEntity
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
        public int PilotoId { get; set; }
        public virtual Piloto Piloto { get; set; }

        private EnderecoPiloto() => Metadata.Create();

        public static EnderecoPiloto Create(string cep, string logradouro, int numero, string complemento, string bairro, int cidadeId, int estadoId, int pilotoId)
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
                EstadoId = estadoId,
                PilotoId = pilotoId
            };
        }

        public void Update(string cep, string logradouro, int numero, string complemento, string bairro, int cidadeId, int estadoId)
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

        public EnderecoPiloto UpdateEstado(int estadoId)
        {
            Metadata.Update();
            EstadoId = estadoId;
            return this;
        }
    }
}