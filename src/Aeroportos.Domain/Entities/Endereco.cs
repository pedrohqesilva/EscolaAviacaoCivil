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
        public Cidade Cidade { get; private set; }
        public Estado Estado { get; private set; }
        public Pais Pais { get; private set; }

        public Endereco(string cep, string logradouro, int numero, string complemento, string bairro, Cidade cidade, Estado estado, Pais pais)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
        }
    }
}