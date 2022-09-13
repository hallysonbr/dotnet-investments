using System.Collections.Generic;
using System.Threading.Tasks;
using Investments.Core.Entities;

namespace Investments.Core.Repositories
{
    public interface IUsuarioRepository
    {
         Task<List<Usuario>> GetAllAsync();        
         Task AddAsync(Usuario usuario);         
         Task SaveChangesAsync();
    }
}