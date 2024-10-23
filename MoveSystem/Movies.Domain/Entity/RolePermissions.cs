using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain.Entity
{
    public class RolePermissions
    {
        public int RoleId { get; set; }  // جزء من المفتاح الأساسي
        public int PermissionId { get; set; }  // جزء آخر من المفتاح الأساسي
        public Role Role { get; set; }
        public Permissions Permissions { get; set; }
    }
}
