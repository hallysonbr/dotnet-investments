using System.Threading.Tasks;
using Investments.Application.Commands.CadastrarAtivo;
using Investments.Application.Queries.GetAllAtivos;
using Investments.Application.Queries.GetAllTipoAtivo;
using Investments.Application.Queries.GetAtivoById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Investments.API.Controllers
{
    [ApiController]
    [Route("api/ativo")]
    public class AtivoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AtivoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Cliente")]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllAtivosQuery();
            var ativos = await _mediator.Send(query);
            return Ok(ativos);
        }

        [HttpGet("grupo")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetGrupos()
        {
            var query = new GetAllTipoAtivoQuery();
            var tiposAtivo = await _mediator.Send(query);
            return Ok(tiposAtivo);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin, Cliente")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetAtivoByIdQuery(id);
            var ativo = await _mediator.Send(query);

            if(ativo is null) return NotFound();

            return Ok(ativo);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Post([FromBody] CadastrarAtivoCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
    }
}