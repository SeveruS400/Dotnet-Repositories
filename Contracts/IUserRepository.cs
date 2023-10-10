using Entities.Models;


namespace Repositories.Contracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        IQueryable<User> GetAllUsers(bool trackChanges);

    }
}
