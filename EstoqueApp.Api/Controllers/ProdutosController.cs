using EstoqueApp.Application.Interfaces.Services;
using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Application.Models.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoAppService? _produtoAppService;

        public ProdutosController(IProdutoAppService? produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ProdutoQuery), 201)]
        public async Task<IActionResult> Post(ProdutoCreateCommand command)
        {
            return StatusCode(201, await _produtoAppService?.Create(command));
        }

        [HttpPut]
        [ProducesResponseType(typeof(ProdutoQuery), 200)]
        public async Task<IActionResult> Put(ProdutoUpdateCommand command)
        {
            return StatusCode(200, await _produtoAppService?.Update(command));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ProdutoQuery), 200)]
        public async Task<IActionResult> Delete(Guid? id)
        {
            var command = new ProdutoDeleteCommand { Id = id };
            return StatusCode(200, await _produtoAppService?.Delete(command));
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ProdutoQuery>), 200)]
        public IActionResult GetAll()
        {
            return StatusCode(200, _produtoAppService?.GetAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProdutoQuery), 200)]
        public IActionResult GetById(Guid? id)
        {
            return StatusCode(200, _produtoAppService?.GetById(id));
        }
    }
}

