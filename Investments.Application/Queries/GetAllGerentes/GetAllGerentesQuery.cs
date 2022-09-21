using System.Collections.Generic;
using Investments.Application.ViewModels;
using MediatR;

namespace Investments.Application.Queries.GetAllGerentes
{
    public class GetAllGerentesQuery : IRequest<List<UsuarioViewModel>>
    {
        
    }
}