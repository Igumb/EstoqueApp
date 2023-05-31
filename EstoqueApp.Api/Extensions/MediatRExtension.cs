using MediatR;

namespace EstoqueApp.API.Extensions
{
    public static class MediatRExtension
    {
        public static IServiceCollection AddMediatR(this IServiceCollection services)
        {
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}



