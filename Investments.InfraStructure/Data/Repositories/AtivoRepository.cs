using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investments.Core.Entities;
using Investments.Core.Repositories;
using Investments.InfraStructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Investments.InfraStructure.Data.Repositories
{
    public class AtivoRepository : IAtivoRepository
    {
        private readonly InvestmentsContext _context;

        public AtivoRepository(InvestmentsContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Ativo ativo)
        {
            await _context.Ativos.AddAsync(ativo);            
        }

        public async Task<List<Ativo>> GetAllAsync()
        {
            return await _context.Ativos.ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}