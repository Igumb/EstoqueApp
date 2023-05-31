using EstoqueApp.Application.Interfaces.Persistences;
using EstoqueApp.Application.Interfaces.Services;
using EstoqueApp.Application.Services;
using EstoqueApp.Domain.Interfaces.Repositories;
using EstoqueApp.Domain.Interfaces.Services;
using EstoqueApp.Domain.Services;
using EstoqueApp.Infra.Data.MongoDB.Contexts;
using EstoqueApp.Infra.Data.MongoDB.Persistences;
using EstoqueApp.Infra.Data.MongoDB.Settings;
using EstoqueApp.Infra.Data.SqlServer.Repositories;
using MediatR;

namespace EstoqueApp.API.Extensions
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoDbSettings>(configuration.GetSection("MongoDbSettings"));

            services.AddTransient<IEstoqueAppService, EstoqueAppService>();
            services.AddTransient<IProdutoAppService, ProdutoAppService>();

            services.AddTransient<IEstoqueDomainService, EstoqueDomainService>();
            services.AddTransient<IProdutoDomainService, ProdutoDomainService>();

            services.AddTransient<IEstoquePersistence, EstoquePersistence>();
            services.AddTransient<IProdutoPersistence, ProdutoPersistence>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<MongoDbContext>();

            return services;
        }
    }
}



