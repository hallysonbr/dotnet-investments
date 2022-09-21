using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Investments.Application.ViewModels;
using Investments.Core.Repositories;
using MediatR;

namespace Investments.Application.Queries.GetAllAtivos
{
    public class GetAllAtivosQueryHandler : IRequestHandler<GetAllAtivosQuery, List<AtivoViewModel>>
    {
        private readonly IUnitOfWork _uof;

        public GetAllAtivosQueryHandler(IUnitOfWork uof)
        {
            _uof = uof;
        }

        public async Task<List<AtivoViewModel>> Handle(GetAllAtivosQuery request, CancellationToken cancellationToken)
        {
           var ativos = await _uof.AtivoRepository.GetAllAsync();

           var ativosVm = ativos.Select(a => new AtivoViewModel(a.Id, a.Nome, a.Tipo)).ToList();

           return ativosVm;
        }
    }
          
}