using System.Threading;
using System.Threading.Tasks;
using Investments.Application.ViewModels;
using Investments.Core.Repositories;
using MediatR;

namespace Investments.Application.Queries.GetUsuarioById
{
    public class GetUsuarioByIdQueryHandler : IRequestHandler<GetUsuarioByIdQuery, UsuarioViewModel>
    {
        private readonly IUnitOfWork _uof;

        public GetUsuarioByIdQueryHandler(IUnitOfWork uof)
        {
            _uof = uof;
        }
        public async Task<UsuarioViewModel> Handle(GetUsuarioByIdQuery request, CancellationToken cancellationToken)
        {
            var usuario = await _uof.UsuarioRepository.GetByIdAsync(request.Id);

            if(usuario is null) return null;
            
            return new UsuarioViewModel(usuario.Id, usuario.Nome, usuario.Email, usuario.CalcularIdade(), usuario.Tipo, usuario.Ativos);
        }
    }
}