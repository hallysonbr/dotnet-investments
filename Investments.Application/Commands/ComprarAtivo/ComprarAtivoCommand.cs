using Investments.Application.DTOs;
using MediatR;

namespace Investments.Application.Commands.ComprarAtivo
{
    public class ComprarAtivoCommand : IRequest<Unit>
    {
        public CarteiraDTO Carteira { get; set; }
    }
}