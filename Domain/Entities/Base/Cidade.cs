namespace Domain.Entities.Base
{
    public class Cidade : BaseEntity
    {
        public string Sigla { get; private set; }
        public string Descricao { get; private set; }
        public int EstadoId { get; private set; }
        public Estado Estado { get; private set; }

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