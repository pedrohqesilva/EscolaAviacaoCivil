using Aeroportos.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Aeroportos.Application.Interfaces
{
    public interface IAeroportoAppService
    {
        Task AdicionarAsync(AdicionarAeroportoDto aeroportoDto, CancellationToken cancellationToken);

        Task AlterarAsync(AlterarAeroportoDto aeroportoDto, CancellationToken cancellationToken);

        Task Remover(Guid guid, CancellationToken cancellationToken);

        Task<AeroportoDto> ObterPorCodigoIcao(string codigoIcao, CancellationToken cancellationToken);

        Task<IEnumerable<AeroportoDto>> ObterPorTipoAeroporto(AeroportoFiltroDto filtroDto, CancellationToken cancellationToken);
    }
}