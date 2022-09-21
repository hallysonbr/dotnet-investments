using System.Collections.Generic;
using Investments.Application.ViewModels;
using MediatR;

namespace Investments.Application.Queries.GetAllTipoAtivo
{
    public class GetAllTipoAtivoQuery : IRequest<List<TipoAtivoViewModel>>
    {
        
    }
}