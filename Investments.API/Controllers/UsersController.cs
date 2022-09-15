using System.Threading.Tasks;
using Investments.Application.Commands.CadastrarCliente;
using Investments.Application.Commands.CadastrarGerente;
using Investments.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Investiments.API.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost("gerente")]
        public async Task<IActionResult> Post([FromBody] CadastrarGerenteCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPost("cliente")]
        public async Task<IActionResult> PostCliente([FromBody] CadastrarClienteCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
    }
}
