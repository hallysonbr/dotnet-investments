using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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