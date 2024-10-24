using Ecommerce.Application.Repository;
using Movies.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Repository
{
    public interface IUserRepositorycs : IRepository<User>
    {
        Task LoginAsync(string username, string password);
        Task<User> RegisterAsync(User user);
        Task LogoutAsync();
        Task DetailsAsync(int id);
    }
}
