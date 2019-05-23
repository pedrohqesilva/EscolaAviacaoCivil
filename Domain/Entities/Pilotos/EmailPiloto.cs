using Domain.Entities.Base;

namespace Domain.Entities.Pilotos
{
    public class EmailPiloto : BaseEntity
    {
        public string Endereco { get; set; }
        public int PilotoId { get; set; }
        public Piloto Piloto { get; set; }

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