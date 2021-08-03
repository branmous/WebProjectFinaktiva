using Infraestructure.Model.Model;
using System.Linq;

namespace Infraestructure.Repository.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly EntityContext context;

        public UserRepository(EntityContext context) : base(context)
        {
            this.context = context;
        }

        public User Autenticate(string userName, string password)
        {
            return this.context.Users.FirstOrDefault(u => u.Username == userName && u.Password == password);
        }

        public User GetById(int userId)
        {
            return this.context.Users.FirstOrDefault(u => u.Id == userId);
        }
    }
}
