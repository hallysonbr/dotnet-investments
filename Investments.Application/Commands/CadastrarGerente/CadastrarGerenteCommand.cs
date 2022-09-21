using Investments.Application.DTOs;
using MediatR;

namespace Investments.Application.Commands.CadastrarGerente
{
    public class CadastrarGerenteCommand : IRequest<int>
    {        
       public UsuarioDTO Usuario { get; set; }
    }
}