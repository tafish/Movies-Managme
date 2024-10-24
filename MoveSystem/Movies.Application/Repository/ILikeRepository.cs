using Ecommerce.Application.Repository;
using Movies.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Repository
{
    public interface ILikeRepository : IRepository<Like>
    {
        Task LikeAsync(int id, string username);
    }
}
