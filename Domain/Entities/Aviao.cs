using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Aviao : BaseEntity
    {
        public string Matricula { get; private set; }
        public int AviaoId { get; set; }
        public virtual Modelo Modelo { get; set; }

        private Aviao() => Metadata.Create();

        public static Aviao Create(string matricula)
        {
            return new Aviao
            {
                Matricula = matricula
            };
        }

        public Aviao UpdateMatricula(string matricula)
        {
            Metadata.Update();
            Matricula = matricula;
            return this;
        }
    }
}