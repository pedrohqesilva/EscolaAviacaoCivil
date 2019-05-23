namespace Domain.Entities.Base
{
    public class Estado : BaseEntity
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }

        private Estado() => Metadata.Create();

        public static Estado Create(string sigla, string descricao, int paisId)
        {
            return new Estado
            {
                Sigla = sigla,
                Descricao = descricao,
                PaisId = paisId
            };
        }
    }
}