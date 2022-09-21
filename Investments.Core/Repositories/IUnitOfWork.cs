using System;
using System.Threading.Tasks;

namespace Investments.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IAtivoRepository AtivoRepository { get; }
        ICarteiraRepository CarteiraRepository { get; }
        IUsuarioRepository UsuarioRepository { get; }

        Task<int> Commit();
        void Rollback();
    }
}