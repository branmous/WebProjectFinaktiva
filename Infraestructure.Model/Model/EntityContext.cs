using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Model.Model
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Rol> Roles { get; set; }
    }
}
