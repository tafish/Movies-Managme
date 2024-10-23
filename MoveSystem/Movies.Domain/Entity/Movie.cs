using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain.Entity
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string ?Image { get; set; }
        public string ?Video { get; set; }
        public bool IsFree { get; set; }
        public int CategoryId { get; set; }
        public Category? category { get; set; }
        public ICollection<Reviews> Reviews { get; set; } = new List<Reviews>();



    }
}
