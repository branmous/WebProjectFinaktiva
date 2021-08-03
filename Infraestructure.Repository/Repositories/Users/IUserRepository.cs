using Infraestructure.Model.Model;

namespace Infraestructure.Repository.Repositories.Users
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User Autenticate(string userName, string password);
        User GetById(int userId);
    }
}
