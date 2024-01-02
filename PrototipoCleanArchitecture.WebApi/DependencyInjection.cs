using PrototipoCleanArchitecture.Application;

namespace PrototipoCleanArchitecture.WebApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServicesApp(this IServiceCollection services, IConfiguration configuration)
        {
    
            services.AddInfrastructure(configuration);
            services.AddApplication();

            return services;
        }
    }
}
