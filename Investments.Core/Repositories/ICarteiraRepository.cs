using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investments.Core.Entities;

namespace Investments.Core.Repositories
{
    public interface ICarteiraRepository
    {         
         Task AddAsync(Carteira carteira);
         Task UpdateAsync();         
         Task SaveChangesAsync();
    }
}