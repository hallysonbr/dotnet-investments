using System;
using System.Collections.Generic;
using System.Linq;
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
            var usuario = await _uof.UsuarioRepository.GetById(request.Id);

            if(usuario is null) return null;
            
            return new UsuarioViewModel(usuario.Nome, usuario.Email, usuario.DataNascimento);
        }
    }
}