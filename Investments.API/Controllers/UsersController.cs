using System.Threading.Tasks;
using Investments.Application.Commands.CadastrarCarteira;
using Investments.Application.Commands.CadastrarCliente;
using Investments.Application.Commands.CadastrarGerente;
using Investments.Application.Queries.GetAllClientes;
using Investments.Application.Queries.GetAllGerentes;
using Investments.Application.Queries.GetUsuarioById;
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

        [HttpGet("gerente")]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllGerentesQuery();
            var users = await _mediator.Send(query);
            return Ok(users);
        }

        [HttpGet("cliente")]
        public async Task<IActionResult> GetCliente()
        {
            var query = new GetAllClientesQuery();
            var users = await _mediator.Send(query);
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetUsuarioByIdQuery(id);
            var user = await _mediator.Send(query);

            if(user is null) return NotFound();

            return Ok(user);
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

        [HttpPost("cliente/{id}/carteira")]
        public async Task<IActionResult> PostCarteira([FromBody] CadastrarCarteiraCommand command)
        {
            var id = await _mediator.Send(command);

            if(id <= 0) return BadRequest();
            
            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
    }
}
