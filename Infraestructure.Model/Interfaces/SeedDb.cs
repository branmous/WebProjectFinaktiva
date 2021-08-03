using Infraestructure.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Model.Interfaces
{
    public class SeedDb
    {
        private readonly EntityContext context;
        public SeedDb(EntityContext context)
        {
            this.context = context;
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            Rol rolAdmin = this.context.Roles.FirstOrDefault(r => r.Description == "ADMIN");
            if (rolAdmin == null)
            {
                Rol role = new Rol
                {
                    Description = "ADMIN"
                };

                this.context.Roles.Add(role);
                this.context.SaveChanges();
            }

            Rol rolOp = this.context.Roles.FirstOrDefault(r => r.Description == "OPERATIVE");
            if (rolOp == null)
            {
                Rol role = new Rol
                {
                    Description = "OPERATIVE"
                };

                this.context.Roles.Add(role);
                this.context.SaveChanges();
            }

            User user = this.context.Users.FirstOrDefault(u => u.Username == "branmous");

            if (user == null)
            {
                User userNew = new User
                {
                    FirstName = "Brandon",
                    LastName = "Montoya",
                    Password = "clave123",
                    Username = "branmous",
                    RolId = 1
                };

                this.context.Users.Add(userNew);
                this.context.SaveChanges();
            }
        }
    }
}
