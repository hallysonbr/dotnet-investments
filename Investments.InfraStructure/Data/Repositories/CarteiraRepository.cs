using System.Threading.Tasks;
using Investments.Core.Entities;
using Investments.Core.Repositories;
using Investments.InfraStructure.Data.Context;
using Microsoft.EntityFrameworkCore;

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
        }

        public async Task<Carteira> GetByIdUsuarioAndIdAtivo(int usuarioId, int ativoId)
        {
            return await _context.Carteiras.FirstOrDefaultAsync(c => c.UsuarioId == usuarioId 
                                                                  && c.AtivoId == ativoId);
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