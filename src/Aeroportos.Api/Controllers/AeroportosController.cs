using Aeroportos.Api.Controllers.Base;
using Aeroportos.Application.Dtos;
using Aeroportos.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Aeroportos.Api.Controllers
{
    [Route("api/Aeroportos")]
    [Produces("application/json")]
    [ApiController]
    public class AeroportosController : BaseController
    {
        private readonly IAeroportoAppService _aeroportoAppService;

        public AeroportosController(IAeroportoAppService aeroportoAppService)
        {
            _aeroportoAppService = aeroportoAppService;
        }

        [HttpPost]
        [Route("AdicionarAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Post([FromBody] AdicionarAeroportoDto aeroportoDto, CancellationToken cancellationToken)
        {
            await _aeroportoAppService.AdicionarAsync(aeroportoDto, cancellationToken);
            return NoContent();
        }

        [HttpPut]
        [Route("AlterarAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Put([FromBody] AlterarAeroportoDto aeroportoDto, CancellationToken cancellationToken)
        {
            await _aeroportoAppService.AlterarAsync(aeroportoDto, cancellationToken);
            return NoContent();
        }

        [HttpDelete]
        [Route("RemoverAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete(Guid guid, CancellationToken cancellationToken)
        {
            await _aeroportoAppService.Remover(guid, cancellationToken);
            return NoContent();
        }

        [HttpGet]
        [Route("ObterPorCodigoIcao")]
        [ProducesResponseType(typeof(AeroportoDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string codigoIcao, CancellationToken cancellationToken)
        {
            var aeroporto = await _aeroportoAppService.ObterPorCodigoIcao(codigoIcao, cancellationToken);
            return Ok(aeroporto);
        }

        [HttpGet]
        [Route("ObterPorTipoAeroporto")]
        [ProducesResponseType(typeof(AeroportoDto), StatusCodes.Status200OK)]
        public async Task<IEnumerable<IActionResult>> Get(AeroportoFiltroDto filtroDto, CancellationToken cancellationToken)
        {
            filtroDto.Pagination = Pagination;
            var aeroportos = await _aeroportoAppService.ObterPorTipoAeroporto(filtroDto, cancellationToken);

            SetPaginationHeaderInfo(filtroDto.Pagination);
            return new[] { Ok(aeroportos) };
        }
    }
}