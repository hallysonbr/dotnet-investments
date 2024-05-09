using System;
using System.Threading.Tasks;
using Investments.Core.Repositories;
using Investments.InfraStructure.Data.Context;

namespace Investments.InfraStructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly InvestmentsContext _context;

        public UnitOfWork(InvestmentsContext context)
        {
            _context = context;
        }

        private AtivoRepository _ativoRepository;
        private CarteiraRepository _carteiraRepository;
        private UsuarioRepository _usuarioRepository;

        public IAtivoRepository AtivoRepository
        {
            get { return _ativoRepository ??= new AtivoRepository(_context); }
        }

        public ICarteiraRepository CarteiraRepository
        {
            get { return _carteiraRepository ??= new CarteiraRepository(_context);}
        }

        public IUsuarioRepository UsuarioRepository
        {
           get { return _usuarioRepository ??= new UsuarioRepository(_context); }
        }

        public async Task<int> Commit()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Dispose()
        {
            try
            {
                if (_context != null)
                    _context.Dispose();

                GC.SuppressFinalize(this);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Rollback()
        {
            //Não é necessário implementar com EntityFramework
        }
    }
}