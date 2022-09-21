using System.Threading;
using System.Threading.Tasks;
using Investments.Core.Entities;
using Investments.Core.Repositories;
using MediatR;

namespace Investments.Application.Commands.CadastrarCarteira
{
    public class CadastrarCarteiraCommandHandler : IRequestHandler<CadastrarCarteiraCommand, int>
    {
        private readonly IUnitOfWork _uof;

        public CadastrarCarteiraCommandHandler(IUnitOfWork uof)
        {
            _uof = uof;
        }

        public async Task<int> Handle(CadastrarCarteiraCommand request, CancellationToken cancellationToken)
        {
            //Fail Fast Validation            
            var carteira = await _uof.CarteiraRepository.GetByIdUsuarioAndIdAtivo(request.UsuarioId, request.AtivoId);
            if(carteira is not null) return -1;

            carteira = new Carteira(request.UsuarioId, request.AtivoId, request.Saldo);

            await _uof.CarteiraRepository.AddAsync(carteira);
            await _uof.Commit();

            return carteira.Id;
        }
    }
}