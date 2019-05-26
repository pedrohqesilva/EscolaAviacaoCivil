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

        Task RemoverAsync(Aeroporto aeroporto, CancellationToken cancellationToken);

        Task<IList<Aeroporto>> ObterAeroportos(CancellationToken cancellationToken);

        Task<Aeroporto> ObterAeroportoPorCodigoIcao(string codigoIcao, CancellationToken cancellationToken);
    }
}