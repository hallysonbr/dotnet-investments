using System.Threading;
using System.Threading.Tasks;
using Investments.Application.ViewModels;
using Investments.Core.Repositories;
using MediatR;

namespace Investments.Application.Queries.GetAtivoById
{
    public class GetAtivoByIdQueryHandler : IRequestHandler<GetAtivoByIdQuery, AtivoViewModel>
    {
        private readonly IUnitOfWork _uof;

        public GetAtivoByIdQueryHandler(IUnitOfWork uof)
        {
            _uof = uof;
        }

        public async Task<AtivoViewModel> Handle(GetAtivoByIdQuery request, CancellationToken cancellationToken)
        {
            var ativo = await _uof.AtivoRepository.GetByIdAsync(request.Id);

            if(ativo is null) return null;

            return new AtivoViewModel(ativo.Id, ativo.Nome, ativo.Tipo);
        }
    }
}