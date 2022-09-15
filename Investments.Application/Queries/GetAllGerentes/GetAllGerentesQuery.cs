using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investments.Application.ViewModels;
using MediatR;

namespace Investments.Application.Queries.GetAllGerentes
{
    public class GetAllGerentesQuery : IRequest<List<UsuarioViewModel>>
    {
        
    }
}