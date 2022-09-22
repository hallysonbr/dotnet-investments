using System.Threading.Tasks;
using Investments.Core.Entities;

namespace Investments.Core.Repositories
{
    public interface ICarteiraRepository
    {         
         Task AddAsync(Carteira carteira);
         Task<Carteira> GetByIdUsuarioAndIdAtivo(int usuarioId, int ativoId);
         Task UpdateAsync();
         Task DeleteAsync(Carteira carteira);         
         Task SaveChangesAsync();
    }
}