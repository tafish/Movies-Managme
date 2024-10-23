using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Movies.Domain.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int Age { get; set; }
        public ICollection<RoleUser> RoleUser { get; set; } = new List<RoleUser>();
        public ICollection<Reviews> Reviews { get; set; } = new List<Reviews>();
    }
}





