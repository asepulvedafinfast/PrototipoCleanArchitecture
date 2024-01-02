namespace PrototipoCleanArchitecture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddRepositories();
            services.AddDatabase(configuration);
            services.AddControllers();

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IActividadEconomicaDeudorRepository, ActividadEconomicaDeudorRepository>();

            return services;
        }

        private static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("CFTOnline");

            services.AddSingleton<IConfiguration>(configuration);

            services.AddDbContext<Context>(x => x.UseSqlServer(connectionString, x => x.EnableRetryOnFailure()));

            services.AddScoped<IUnitOfWork>(p =>
               p.GetRequiredService<Context>());

            return services;
        }

        private static IServiceCollection AddControllers(this IServiceCollection services)
        {
            services.AddScoped<IActividadEconomicaDeudorController, ActividadEconomicaDeudorController>();
 
           return services;
        }
    }
}
