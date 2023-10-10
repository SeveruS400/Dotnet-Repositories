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
        public IQueryable<User> GetUser(int id)
        {
            return _context.Users.Where(u => u.UserId == id).AsQueryable();
        }
        public async Task<bool> DeleteUserAsync(int id)
        {
            var userToDelete = await _context.Users.FindAsync(id);

            if (userToDelete != null)
            {
                _context.Users.Remove(userToDelete);
                await _context.SaveChangesAsync();
                return true; // Başarıyla silindi
            }

            return false; // Kullanıcı bulunamadı
        }
    }
}
