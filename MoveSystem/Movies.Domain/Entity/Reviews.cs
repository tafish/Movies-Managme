using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain.Entity
{
    public class Reviews
    {
        public int Id { get; set; }          
        public string Content { get; set; }  
        public int Rate { get; set; }         
        public DateTime Date { get; set; }   
        public int UserId { get; set; }       
        public int MovieId { get; set; }     
        public User User { get; set; }        
        public Movie Movie { get; set; }
        public ICollection<Like> Likes { get; set; }
    }
}
