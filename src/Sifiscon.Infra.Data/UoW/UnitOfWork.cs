using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sifiscon.Infra.Data.Context;
using Sifiscon.Infra.Data.Interfaces;

namespace Sifiscon.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SifisconContext _context;
        private bool _disposed;

        public UnitOfWork(SifisconContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
