using Domain.Entities.Base;

namespace Domain.Entities.Pilotos
{
    public class EmailPiloto : BaseEntity
    {
        public string Endereco { get; private set; }
        public int PilotoId { get; private set; }
        public Piloto Piloto { get; private set; }

        private EmailPiloto() => Metadata.Create();

        public static EmailPiloto Create(string endereco, int pilotoId)
        {
            return new EmailPiloto
            {
                Endereco = endereco,
                PilotoId = pilotoId
            };
        }

        public EmailPiloto UpdateEndereco(string endereco)
        {
            Metadata.Update();
            Endereco = endereco;
            return this;
        }
    }
}