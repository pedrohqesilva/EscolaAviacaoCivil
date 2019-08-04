using Core.Domain.Entities;

namespace Aeroportos.Domain.Entities
{
    public class Aeroporto : BaseEntity
    {
        public string CodigoIcao { get; private set; }
        public string CodigoIata { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public virtual TipoAeroporto TipoAeroporto { get; private set; }
        public virtual Endereco Endereco { get; private set; }

        public Aeroporto(string codigoIcao, string codigoIata, string nome, string descricao, TipoAeroporto tipoAeroporto, Endereco endereco)
        {
            CodigoIcao = codigoIcao;
            CodigoIata = codigoIata;
            Nome = nome;
            Descricao = descricao;
            TipoAeroporto = tipoAeroporto;
            Endereco = endereco;
        }

        public void Alterar(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}