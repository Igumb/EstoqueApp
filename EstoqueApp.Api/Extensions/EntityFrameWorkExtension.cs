using EstoqueApp.Infra.Data.SqlServer.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EstoqueApp.API.Extensions
{
    public static class EntityFrameworkExtension
    {
        public static IServiceCollection AddEntityFramework
           (this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("EstoqueApp");
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            return services;
        }
    }
}



