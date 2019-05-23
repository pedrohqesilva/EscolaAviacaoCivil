using Domain.Entities.Base;
using System;

namespace Domain.Entities.Avioes
{
    public class Aviao : BaseEntity
    {
        public string Matricula { get; private set; }
        public DateTime DataInscricao { get; private set; }
        public string Observacao { get; private set; }
        public int ModeloId { get; set; }
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