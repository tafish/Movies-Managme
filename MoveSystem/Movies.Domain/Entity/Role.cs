using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain.Entity
{
    public class Role
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<RoleUser> RoleUser { get; set; } = new List<RoleUser>();
        public ICollection<RolePermissions> RolePermissions { get; set; } = new List<RolePermissions>();
    }
}
