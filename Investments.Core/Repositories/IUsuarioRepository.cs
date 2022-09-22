using System.Collections.Generic;
using System.Threading.Tasks;
using Investments.Core.Entities;

namespace Investments.Core.Repositories
{
    public interface IUsuarioRepository
    {
         Task<List<Usuario>> GetAllAsync();
         Task<Usuario> GetByIdAsync(int id);
         Task<Usuario> GetByEmailAndPasswordAsync(string email, string password);        
         Task AddAsync(Usuario usuario);         
         Task SaveChangesAsync();
    }
}