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
    public class UserRepository :Repository<User>, IUserRepositorycs
    {
        public UserRepository(DBContextApplication context) : base(context)
        {
        }

        public Task DetailsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task LoginAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> RegisterAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
