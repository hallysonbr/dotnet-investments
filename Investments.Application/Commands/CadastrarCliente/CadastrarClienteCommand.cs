using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investments.Application.DTOs;
using MediatR;

namespace Investments.Application.Commands.CadastrarCliente
{
    public class CadastrarClienteCommand : IRequest<int>
    {
        public UsuarioDTO Usuario { get; set; }
    }
}