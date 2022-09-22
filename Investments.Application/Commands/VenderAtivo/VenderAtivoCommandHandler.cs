using System.Threading;
using System.Threading.Tasks;
using Investments.Core.Repositories;
using MediatR;

namespace Investments.Application.Commands.VenderAtivo
{
    public class VenderAtivoCommandHandler : IRequestHandler<VenderAtivoCommand, int>
    {
        private readonly IUnitOfWork _uof;

        public VenderAtivoCommandHandler(IUnitOfWork uof)
        {
            _uof = uof;
        }
        
        public async Task<int> Handle(VenderAtivoCommand request, CancellationToken cancellationToken)
        {
            //Fail Fast Validation
            var carteira = await _uof.CarteiraRepository.GetByIdUsuarioAndIdAtivo(request.Carteira.UsuarioId, 
                                                                                  request.Carteira.AtivoId);

            if(carteira is null) 
                return -1;
            
            carteira.Vender(request.Carteira.Saldo);

            if(carteira.Saldo <= 0)
                await _uof.CarteiraRepository.DeleteAsync(carteira);
                        
            await _uof.Commit();

            return carteira.Id;
        }
    }
}