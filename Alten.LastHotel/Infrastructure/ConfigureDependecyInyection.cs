using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Alten.LastHotel.Persistence
{
    public class ConfigureDependecyInyection
    {
        public static void RegisterDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LastHotelContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("ConnectionDatabase"));
            });
        }
    }
}
