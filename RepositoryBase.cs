using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System.Linq.Expressions;

namespace Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class, new()
    {
        protected readonly DataContext _context;

        protected RepositoryBase(DataContext context)
        {
            _context = context;
        }


        public IQueryable<T> GetAll(bool trackChanges)
        {
            return trackChanges
                ? _context.Set<T>()
                : _context.Set<T>().AsNoTracking();
        }

        public Task<T?> GetByIdAsync(int Id)
        {
            return _context.Set<T>().FindAsync(Id).AsTask();
        }

        public Task CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int Id, T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
