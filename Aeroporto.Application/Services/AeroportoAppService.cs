using Aeroportos.Application.Dtos;
using Aeroportos.Application.Interfaces;
using Aeroportos.Domain.Entities;
using Aeroportos.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Aeroportos.Application.Services
{
    public class AeroportoAppService : IAeroportoAppService
    {
        private readonly IMapper _mapper;
        private readonly IAeroportoService _aeroportoService;

        public AeroportoAppService(IMapper mapper,
            IAeroportoService aeroportoService)
        {
            _mapper = mapper;
            _aeroportoService = aeroportoService;
        }

        public Task AdicionarAsync(AdicionarAeroportoDto aeroportoDto, CancellationToken cancellationToken)
        {
            var aeroporto = _mapper.Map<Aeroporto>(aeroportoDto);
            return Task.FromResult(
                _aeroportoService.AdicionarAsync(aeroporto, cancellationToken)
            );
        }

        public Task AlterarAsync(AlterarAeroportoDto aeroportoDto, CancellationToken cancellationToken)
        {
            return Task.FromResult(
                _aeroportoService.AlterarAsync(
                    aeroportoDto.CodigoIcao,
                    aeroportoDto.Nome,
                    aeroportoDto.Descricao,
                    cancellationToken)
            );
        }

        public async Task Remover(Guid guid, CancellationToken cancellationToken)
        {
            var aeroporto = await _aeroportoService.ObterPorGuid(guid, cancellationToken);
            _aeroportoService.Remover(aeroporto);
        }

        public Task<AeroportoDto> ObterPorCodigoIcao(string codigoIcao, CancellationToken cancellationToken)
        {
            var aeroportos = _aeroportoService.ObterPorCodigoIcao(codigoIcao, cancellationToken);
            return Task.FromResult(
                _mapper.Map<AeroportoDto>(aeroportos)
            );
        }

        public Task<IEnumerable<AeroportoDto>> ObterPorTipoAeroporto(int codigoTipoAeroporto, CancellationToken cancellationToken)
        {
            var aeroportos = _aeroportoService.ObterPorTipoAeroporto(codigoTipoAeroporto, cancellationToken);
            return Task.FromResult(
                _mapper.Map<IEnumerable<AeroportoDto>>(aeroportos)
            );
        }
    }
}