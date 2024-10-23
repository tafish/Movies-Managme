
using Ecommerce.Infrastructure.Presistance;

using Microsoft.EntityFrameworkCore;

namespace Ecommerce.API
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddAPIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DBContextApplication>(options =>
               options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

           




            return services;
        }



        public static WebApplication UseAPIServices(this WebApplication app)
        {


            return app;
        }
    }
}
