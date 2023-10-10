using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _context;
        private readonly IUserRepository _userrepository;

        public RepositoryManager(DataContext context, IUserRepository userrepository)
        {
            _context = context;
            _userrepository = userrepository;
        }

        public IUserRepository User => _userrepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
