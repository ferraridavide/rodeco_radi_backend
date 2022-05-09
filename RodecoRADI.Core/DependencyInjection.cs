using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RodecoRADI.Core.Persistance;

namespace RodecoRADI.Core
{
    public static class DependencyInjection
    {
        public static void AddRodecoCore(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<RodecoContext>((e) =>
            {
                e.UseSqlServer(connectionString);
            });
        }
    }
}
