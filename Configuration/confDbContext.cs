using Microsoft.EntityFrameworkCore;

namespace Delivery.Configuration
{
    public static class DbContextExtensions
    {
        public static IServiceCollection AddConfDbContext(this IServiceCollection services, ConfigurationManager configuration)
        {
            //services.AddDbDefault(configuration);

            return services;



        }

        //private static IServiceCollection AddDbDefault(this IServiceCollection services, ConfigurationManager configuration)
        //{

        //    return services.AddDbContext<DATAContext>(
        //    options => options.UseSqlServer(configuration.GetConnectionString("Default")));
        //}


    }
}
