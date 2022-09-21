using System.Collections.Generic;
using Investments.Application.ViewModels;
using MediatR;

namespace Investments.Application.Queries.GetAllAtivos
{
    public class GetAllAtivosQuery : IRequest<List<AtivoViewModel>>
    {
        
    }
}