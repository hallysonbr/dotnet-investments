using System.Threading;
using System.Threading.Tasks;
using Investments.Core.Entities;
using Investments.Core.Repositories;
using MediatR;

namespace Investments.Application.Commands.ComprarAtivo
{
    public class ComprarAtivoCommandHandler : IRequestHandler<ComprarAtivoCommand, Unit>
    {
        private readonly IUnitOfWork _uof;

        public ComprarAtivoCommandHandler(IUnitOfWork uof)
        {
            _uof = uof;
        }

        public async Task<Unit> Handle(ComprarAtivoCommand request, CancellationToken cancellationToken)
        {
            var carteira = await _uof.CarteiraRepository.GetByIdUsuarioAndIdAtivo(request.Carteira.UsuarioId, 
                                                                                  request.Carteira.AtivoId);

            if(carteira is null)
            {
                carteira = new Carteira(request.Carteira.UsuarioId, 
                                        request.Carteira.AtivoId, 
                                        request.Carteira.Saldo);
            
                await _uof.CarteiraRepository.AddAsync(carteira);
            } 
            else
                carteira.Comprar(request.Carteira.Saldo);

            await _uof.Commit();

            return Unit.Value;
        }
    }
}