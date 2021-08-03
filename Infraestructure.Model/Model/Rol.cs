using Infraestructure.Model.Interfaces;
using System.Collections.Generic;

namespace Infraestructure.Model.Model
{
    public class Rol : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
