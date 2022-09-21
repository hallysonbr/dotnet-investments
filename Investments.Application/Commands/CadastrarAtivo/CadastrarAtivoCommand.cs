using Investments.Core.Enums;
using MediatR;

namespace Investments.Application.Commands.CadastrarAtivo
{
    public class CadastrarAtivoCommand : IRequest<int>
    {
        public string Nome { get; set; }
        public TipoAtivoEnum Tipo { get; set; }
    }
}