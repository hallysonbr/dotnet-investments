using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investments.Application.ViewModels;
using MediatR;

namespace Investments.Application.Queries.GetAllClientes
{
    public class GetAllClientesQuery : IRequest<List<UsuarioViewModel>>
    {
         
    }
}