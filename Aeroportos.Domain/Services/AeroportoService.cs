using Aeroportos.Domain.Entities;
using Aeroportos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aeroportos.Domain.Services
{
    public class AeroportoService : IAeroportoService
    {
        public AeroportoService()
        {
        }

        public Task AdicionarAsync(Aeroporto aeroporto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task AlterarAsync(string codigoIcao, string nome, string descricao, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Aeroporto> ObterAeroportoPorCodigoIcao(string codigoIcao, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Aeroporto>> ObterAeroportos(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task RemoverAsync(Aeroporto aeroporto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}