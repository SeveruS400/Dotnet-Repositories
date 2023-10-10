using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAll(bool trackChanges);
        Task<T> GetByIdAsync(int Id);
        Task CreateAsync(T entity);
        Task UpdateAsync(int Id,T entity);
        Task<bool> DeleteAsync(int Id);

    }
}
