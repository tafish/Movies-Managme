using Ecommerce.Infrastructure.Presistance;
using Ecommerce.Infrastructure.Services;
using Movies.Application.Repository;
using Movies.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Infrastructure.Services
{
    public class LikeRepository : Repository<Like>, ILikeRepository
    {
        public LikeRepository(DBContextApplication context) : base(context)
        {
        }

        public Task LikeAsync(int id, string username)
        {
            throw new NotImplementedException();
        }
    }
}
