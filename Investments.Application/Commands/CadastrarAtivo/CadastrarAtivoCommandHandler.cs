using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Investments.Core.Entities;
using Investments.Core.Repositories;
using MediatR;

namespace Investments.Application.Commands.CadastrarAtivo
{
    public class CadastrarAtivoCommandHandler : IRequestHandler<CadastrarAtivoCommand, int>
    {
        private readonly IUnitOfWork _uof;

        public CadastrarAtivoCommandHandler(IUnitOfWork uof)
        {
            _uof = uof;
        }

        public async Task<int> Handle(CadastrarAtivoCommand request, CancellationToken cancellationToken)
        {
            var ativo = new Ativo(request.Nome, request.Tipo);

            await _uof.AtivoRepository.AddAsync(ativo);
            await _uof.Commit();

            return ativo.Id;
        }
    }
}