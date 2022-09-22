using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Investments.Application.ViewModels;
using Investments.Core.Enums;
using Investments.Core.Extensions;
using Investments.Core.Repositories;
using Investments.InfraStructure.CrossCutting.Auth.Interfaces;
using MediatR;

namespace Investments.Application.Commands.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, LoginUserViewModel>
    {
        private readonly IUnitOfWork _uof;
        private readonly IAuthService _auth;

        public LoginUserCommandHandler(IUnitOfWork uof, IAuthService auth)
        {
            _uof = uof;
            _auth = auth;
        }

        public async Task<LoginUserViewModel> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _auth.ComputeSha256Hash(request.Password);
            var usuario = await _uof.UsuarioRepository.GetByEmailAndPasswordAsync(request.Email, passwordHash);

            if(usuario is null) return null;

            var token = _auth.GenerateJwtToken(usuario.Email, ((UsuarioTipoEnum)usuario.Tipo).DescriptionAttr());
            return new LoginUserViewModel(usuario.Email, token);          
        }
    }
}