using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Investments.Core.Entities;
using Investments.Core.Enums;
using Investments.Core.Repositories;
using Investments.InfraStructure.CrossCutting.Auth.Interfaces;
using MediatR;

namespace Investments.Application.Commands.CadastrarGerente
{
    public class CadastrarGerenteCommandHandler : IRequestHandler<CadastrarGerenteCommand, int>
    {
        private readonly IUnitOfWork _uof;
        private readonly IAuthService _authService;

        public CadastrarGerenteCommandHandler(IUnitOfWork uof, IAuthService authService)
        {
            _uof = uof;
            _authService = authService;
        }
        public async Task<int> Handle(CadastrarGerenteCommand request, CancellationToken cancellationToken)
        {
            var hashPassword = _authService.ComputeSha256Hash(request.Usuario.Password);
            var gerente = new Usuario(request.Usuario.Nome, 
                                      request.Usuario.Email, 
                                      hashPassword, 
                                      request.Usuario.DataNascimento, 
                                      UsuarioTipoEnum.Gerente);

            await _uof.UsuarioRepository.AddAsync(gerente);
            await _uof.Commit();

            return gerente.Id;
        }
    }
}