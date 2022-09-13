using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investments.Core.Entities;
using Investments.Core.Enums;
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
            await SaveChangesAsync();
        }

        public async Task<List<Usuario>> GetAllAsync()
        {
            return await _context.Usuarios.Include(u => u.Ativos)
                        .Where(a => a.Tipo == UsuarioTipoEnum.Cliente)
                        .ToListAsync();
        }
                
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }       
    }
}