using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
        }

        public IQueryable<User> GetAllUsers(bool trackChanges)
        {
            return trackChanges
                ? _context.Users.AsQueryable()
                : _context.Users.AsNoTracking().AsQueryable();
        }
    }
}
