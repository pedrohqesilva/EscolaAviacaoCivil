namespace Domain.Entities.Base
{
    public class Pais : BaseEntity
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }

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