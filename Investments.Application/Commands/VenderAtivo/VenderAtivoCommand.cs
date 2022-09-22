using Investments.Application.DTOs;
using MediatR;

namespace Investments.Application.Commands.VenderAtivo
{
    public class VenderAtivoCommand : IRequest<int>
    {
        public CarteiraDTO Carteira { get; set; }
    }
}