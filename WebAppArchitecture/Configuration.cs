using Microsoft.EntityFrameworkCore;
using WebAppArchitecture.Data;
using Microsoft.AspNetCore.Builder;

namespace WebAppArchitecture
{
    public static class Configuration
    {
        public static IServiceCollection AddServices(
            this IServiceCollection services)
        {
            services.AddDbContext<Context>(opt => opt.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebAppArchitecture;Trusted_Connection=True;Integrated Security=True;"));
            services.AddControllersWithViews();

            return services;
        }
    }
}
