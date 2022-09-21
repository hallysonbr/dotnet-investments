using System.Collections.Generic;
using System.Threading.Tasks;
using Investments.Core.Entities;

namespace Investments.Core.Repositories
{
    public interface IAtivoRepository
    {
         Task<List<Ativo>> GetAllAsync();
         Task<Ativo> GetByIdAsync(int id);        
         Task AddAsync(Ativo ativo);
         Task SaveChangesAsync();
    }
}