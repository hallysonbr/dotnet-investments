using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investments.Core.Entities;
using Investments.Core.Repositories;
using Investments.InfraStructure.Data.Context;

namespace Investments.InfraStructure.Data.Repositories
{
    public class CarteiraRepository : ICarteiraRepository
    {

        private readonly InvestmentsContext _context;

        public CarteiraRepository(InvestmentsContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Carteira carteira)
        {
            await _context.Carteiras.AddAsync(carteira);
            await SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync()
        {
           await SaveChangesAsync();
        }
    }
}