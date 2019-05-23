namespace Domain.Entities.Base
{
    public class Cidade : BaseEntity
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }

        private Cidade() => Metadata.Create();

        public static Cidade Create(string sigla, string descricao, int estadoId)
        {
            return new Cidade
            {
                Sigla = sigla,
                Descricao = descricao,
                EstadoId = estadoId
            };
        }
    }
}