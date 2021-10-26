using Application.Common.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DbSqlConnectionString"),
                    b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));


            services.AddScoped<IApplicationContext>(provider => provider.GetService<ApplicationContext>());

            //services.AddTransient<IDateTime, DateTimeService>();

            return services;
        }

    }
}
