using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain.Entity
{
    public class Like
    {
        public int Id { get; set; }            
        public int UserId { get; set; }       
        public int ReviewId { get; set; }    
        public bool IsLiked { get; set; } 
        public User User { get; set; }        
        public Reviews Reviews { get; set; }     
    }

}
