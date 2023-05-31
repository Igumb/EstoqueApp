using EstoqueApp.Application.Interfaces.Services;
using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Application.Models.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoquesController : ControllerBase
    {
        private readonly IEstoqueAppService? _estoqueAppService;

        public EstoquesController(IEstoqueAppService? estoqueAppService)
        {
            _estoqueAppService = estoqueAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(EstoqueQuery), 201)]
        public async Task<IActionResult> Post(EstoqueCreateCommand command)
        {
            return StatusCode(201, await _estoqueAppService?.Create(command));
        }

        [HttpPut]
        [ProducesResponseType(typeof(EstoqueQuery), 200)]
        public async Task<IActionResult> Put(EstoqueUpdateCommand command)
        {
            return StatusCode(200, await _estoqueAppService?.Update(command));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(EstoqueQuery), 200)]
        public async Task<IActionResult> Delete(Guid? id)
        {
            var command = new EstoqueDeleteCommand { Id = id };
            return StatusCode(200, await _estoqueAppService?.Delete(command));
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<EstoqueQuery>), 200)]
        public IActionResult GetAll()
        {
            return StatusCode(200, _estoqueAppService?.GetAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(EstoqueQuery), 200)]
        public IActionResult GetById(Guid? id)
        {
            return StatusCode(200, _estoqueAppService.GetById(id));
        }
    }
}



