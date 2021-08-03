using Infraestructure.Model.Interfaces;

namespace Infraestructure.Model.Model
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int RolId { get; set; }

        public virtual Rol Rol { get; set; }

    }
}
