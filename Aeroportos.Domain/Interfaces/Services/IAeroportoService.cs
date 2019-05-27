using Aeroportos.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Aeroportos.Domain.Interfaces.Services
{
    public interface IAeroportoService
    {
        Task AdicionarAsync(Aeroporto aeroporto, CancellationToken cancellationToken);

        Task AlterarAsync(string codigoIcao, string nome, string descricao, CancellationToken cancellationToken);

        void Remover(Aeroporto aeroporto);

        Task<Aeroporto> ObterPorCodigoIcao(string codigoIcao, CancellationToken cancellationToken);

        Task<IEnumerable<Aeroporto>> ObterPorTipoAeroporto(int codigoTipoAeroporto, CancellationToken cancellationToken);
    }
}