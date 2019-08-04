namespace Aeroportos.Domain.Entities
{
    public class Cidade
    {
        public string Sigla { get; private set; }
        public string Descricao { get; private set; }

        public Cidade(string sigla, string descricao)
        {
            Sigla = sigla;
            Descricao = descricao;
        }
    }
}