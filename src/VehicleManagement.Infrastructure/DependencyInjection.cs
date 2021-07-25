using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VehicleManagement.Application.Common.Interfaces;
using VehicleManagement.Application.Common.Interfaces.Repositories;
using VehicleManagement.Infrastructure.Persistence;
using VehicleManagement.Infrastructure.Persistence.Repositories;

namespace VehicleManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
            services.AddScoped<ApplicationDbContext>();
            
            services.AddScoped<IBrandRepository, BrandRepository>();
            
            return services;
        }
    }
}