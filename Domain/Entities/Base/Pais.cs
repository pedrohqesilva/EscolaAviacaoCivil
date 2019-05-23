namespace Domain.Entities.Base
{
    public class Pais : BaseEntity
    {
        public string Sigla { get; private set; }
        public string Descricao { get; private set; }

        private Pais() => Metadata.Create();

        public static Pais Create(string sigla, string descricao)
        {
            return new Pais
            {
                Sigla = sigla,
                Descricao = descricao
            };
        }
    }
}