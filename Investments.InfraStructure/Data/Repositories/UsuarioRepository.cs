using System.Collections.Generic;
using System.Threading.Tasks;
using Investments.Core.Entities;
using Investments.Core.Repositories;
using Investments.InfraStructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Investments.InfraStructure.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly InvestmentsContext _context;

        public UsuarioRepository(InvestmentsContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);           
        }

        public async Task<List<Usuario>> GetAllAsync()
        {
            return await _context.Usuarios.Include(u => u.Ativos)
                                          .ThenInclude(a => a.Ativo)                                                                       
                                          .ToListAsync();
        }

        public async Task<Usuario> GetByEmailAndPasswordAsync(string email, string password)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            return await _context.Usuarios.Include(u => u.Ativos)
                                          .ThenInclude(a => a.Ativo)
                                          .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }       
    }
}