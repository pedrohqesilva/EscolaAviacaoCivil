using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Aviao : BaseEntity
    {
        public string Matricula { get; private set; }

        private Aviao()
        {
            Metadata = Metadata.Create();
        }

        public static Aviao Create(string matricula) => new Aviao { Matricula = matricula };

        public Aviao UpdateMatricula(string matricula)
        {
            Metadata.Update();

            Matricula = matricula;
            return this;
        }
    }
}