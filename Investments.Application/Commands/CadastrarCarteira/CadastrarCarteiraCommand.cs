using Investments.Application.DTOs;
using MediatR;

namespace Investments.Application.Commands.CadastrarCarteira
{
    public class CadastrarCarteiraCommand : IRequest<int>
    {
        public CarteiraDTO Carteira { get; set; }        
    }
}