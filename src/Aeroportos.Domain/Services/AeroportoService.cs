﻿using Aeroportos.Domain.Entities;
using Aeroportos.Domain.Interfaces.Repositories;
using Aeroportos.Domain.Interfaces.Services;
using Aeroportos.Domain.Specifications;
using CrossCutting.Specification;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Aeroportos.Domain.Services
{
    public class AeroportoService : IAeroportoService
    {
        private readonly IAeroportoRepository _aeroportoRepository;

        public AeroportoService(IAeroportoRepository aeroportoRepository)
        {
            _aeroportoRepository = aeroportoRepository;
        }

        public Task AdicionarAsync(Aeroporto aeroporto, CancellationToken cancellationToken)
        {
            return _aeroportoRepository.AddAsync(aeroporto, cancellationToken);
        }

        public async Task AlterarAsync(string codigoIcao, string nome, string descricao, CancellationToken cancellationToken)
        {
            var spec = SpecificationBuilder<Aeroporto>.Create()
                .ComCodigoIcao(codigoIcao)
                .Ativo();

            var aeroporto = await _aeroportoRepository.FirstOrDefaultAsync(spec, cancellationToken);
            aeroporto.Alterar(nome, descricao);

            _aeroportoRepository.Update(aeroporto);
        }

        public void Remover(Aeroporto aeroporto)
        {
            _aeroportoRepository.Remove(aeroporto);
        }

        public Task<Aeroporto> ObterPorGuid(Guid guid, CancellationToken cancellationToken)
        {
            var spec = SpecificationBuilder<Aeroporto>.Create()
                .ComGuid(guid)
                .Ativo();

            return _aeroportoRepository.FirstOrDefaultAsync(spec, cancellationToken);
        }

        public Task<Aeroporto> ObterPorCodigoIcao(string codigoIcao, CancellationToken cancellationToken)
        {
            var spec = SpecificationBuilder<Aeroporto>.Create()
                .ComCodigoIcao(codigoIcao)
                .Ativo();

            return _aeroportoRepository.FirstOrDefaultAsync(spec, cancellationToken);
        }

        public Task<IEnumerable<Aeroporto>> ObterPorTipoAeroporto(int codigoTipoAeroporto, CancellationToken cancellationToken)
        {
            var spec = SpecificationBuilder<Aeroporto>.Create()
                .ComCodigoTipoAeroporto(codigoTipoAeroporto)
                .Ativo();

            return _aeroportoRepository.SearchAsync(spec, cancellationToken);
        }
    }
}