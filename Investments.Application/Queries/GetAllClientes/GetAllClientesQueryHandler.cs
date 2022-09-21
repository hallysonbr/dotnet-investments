using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Investments.Application.ViewModels;
using Investments.Core.Enums;
using Investments.Core.Repositories;
using MediatR;

namespace Investments.Application.Queries.GetAllClientes
{
    public class GetAllClientesQueryHandler : IRequestHandler<GetAllClientesQuery, List<UsuarioViewModel>>
    {
        private readonly IUnitOfWork _uof;

        public GetAllClientesQueryHandler(IUnitOfWork uof)
        {
            _uof = uof;
        }
        
        public async Task<List<UsuarioViewModel>> Handle(GetAllClientesQuery request, CancellationToken cancellationToken)
        {
           var usuarios = await _uof.UsuarioRepository.GetAllAsync();
           var usuariosVm = usuarios.Where(u => u.Tipo == UsuarioTipoEnum.Cliente)
                                    .Select(a => new UsuarioViewModel(a.Id, a.Nome, a.Email, a.CalcularIdade(), a.Tipo, a.Ativos))
                                    .ToList();
            
            return usuariosVm;
        }
    }
}