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
    public class MovieRepository : Repository<Movie>, IMovieRepositorycs 
    {
        public MovieRepository(DBContextApplication context) : base(context)
        {
        }

        public Task DetailsAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
