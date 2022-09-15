using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Investments.Application.ViewModels;
using Investments.Core.Enums;
using Investments.Core.Repositories;
using MediatR;

namespace Investments.Application.Queries.GetAllGerentes
{
    public class GetAllGerentesQueryHandler : IRequestHandler<GetAllGerentesQuery, List<UsuarioViewModel>>
    {
        private readonly IUnitOfWork _uof;

        public GetAllGerentesQueryHandler(IUnitOfWork uof)
        {
            _uof = uof;
        }

        public async Task<List<UsuarioViewModel>> Handle(GetAllGerentesQuery request, CancellationToken cancellationToken)
        {
            var usuarios = await _uof.UsuarioRepository.GetAllAsync();
            var usuariosVm = usuarios.Where(u => u.Tipo == UsuarioTipoEnum.Gerente)
                                    .Select(a => new UsuarioViewModel(a.Nome, a.Email, a.DataNascimento))
                                    .ToList();
            
            return usuariosVm;
        }
    }
}