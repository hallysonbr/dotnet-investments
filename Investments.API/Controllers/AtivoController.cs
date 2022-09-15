using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investments.Application.Commands.CadastrarAtivo;
using MediatR;
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
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CadastrarAtivoCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

    }
}