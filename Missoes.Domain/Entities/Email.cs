using Core.Domain.Entities;

namespace Missoes.Domain.Entities
{
    public class Email : BaseEntity
    {
        public string Endereco { get; private set; }
        public int PilotoId { get; private set; }
        public Piloto Piloto { get; private set; }

        public Email(string endereco, int pilotoId)
        {
            Endereco = endereco;
            PilotoId = pilotoId;
        }

        public Email UpdateEndereco(string endereco)
        {
            Endereco = endereco;
            return this;
        }
    }
}