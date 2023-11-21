using Accounts.Data.Interfaces;
using Accounts.Data.Repositories;

namespace Accounts.Data.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly AccountingDbContext _context;
        private IGRepository<T> _entitiy;
        public UnitOfWork(AccountingDbContext context)
        {
            _context = context;
        }
        public IGRepository<T> Entity
        {
            get
            {
                return _entitiy ?? (_entitiy = new GRepository<T>(_context));
            }
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
