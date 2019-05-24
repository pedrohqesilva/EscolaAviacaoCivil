using Core.Domain.Entities;

namespace Pilotos.Domain.Entities
{
    public class Email : BaseEntity
    {
        #region Properties

        public string Endereco { get; private set; }
        public int PilotoId { get; private set; }
        public virtual Piloto Piloto { get; private set; }

        #endregion Properties

        #region Constructors

        public Email(string endereco, int pilotoId)
        {
            Endereco = endereco;
            PilotoId = pilotoId;
        }

        #endregion Constructors

        #region Update

        public void Update(string endereco)
        {
            this
                .UpdateEndereco(endereco);
        }

        public Email UpdateEndereco(string endereco)
        {
            Endereco = endereco;
            return this;
        }

        public Email UpdatePiloto(int pilotoId)
        {
            PilotoId = pilotoId;
            return this;
        }

        #endregion Update
    }
}