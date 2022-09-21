using System.Collections.Generic;
using Investments.Application.ViewModels;
using MediatR;

namespace Investments.Application.Queries.GetAllClientes
{
    public class GetAllClientesQuery : IRequest<List<UsuarioViewModel>>
    {
         
    }
}