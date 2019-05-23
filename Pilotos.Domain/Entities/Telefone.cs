using Core.Domain.Entities;

namespace Pilotos.Domain.Entities
{
    public class Telefone : BaseEntity
    {
        public int DDD { get; private set; }
        public int Numero { get; private set; }
        public int PilotoId { get; private set; }
        public Piloto Piloto { get; private set; }

        public Telefone(int ddd, int numero, int pilotoId)
        {
            DDD = ddd;
            Numero = numero;
            PilotoId = pilotoId;
        }

        public void Update(int ddd, int numero)
        {
            this
                .UpdateDDD(ddd)
                .UpdateNumero(numero);
        }

        public Telefone UpdateDDD(int ddd)
        {
            DDD = ddd;
            return this;
        }

        public Telefone UpdateNumero(int numero)
        {
            Numero = numero;
            return this;
        }
    }
}