using Domain.Entities.Base;

namespace Domain.Entities.Pilotos
{
    public class TelefonePiloto : BaseEntity
    {
        public int DDD { get; set; }
        public int Numero { get; set; }
        public int PilotoId { get; set; }
        public Piloto Piloto { get; set; }

        private TelefonePiloto() => Metadata.Create();

        public static TelefonePiloto Create(int ddd, int numero, int pilotoId)
        {
            return new TelefonePiloto
            {
                DDD = ddd,
                Numero = numero,
                PilotoId = pilotoId
            };
        }

        public void Update(int ddd, int numero)
        {
            this
                .UpdateDDD(ddd)
                .UpdateNumero(numero);
        }

        public TelefonePiloto UpdateDDD(int ddd)
        {
            Metadata.Update();
            DDD = ddd;
            return this;
        }

        public TelefonePiloto UpdateNumero(int numero)
        {
            Metadata.Update();
            Numero = numero;
            return this;
        }
    }
}