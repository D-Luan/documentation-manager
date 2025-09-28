using DocumentationManager.WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace DocumentationManager.WebAPI.Extensions;

public static class ServiceExtensions
{
    public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DocumentationContext>(opt =>
            opt.UseNpgsql(configuration.GetConnectionString("DocumentationManagerDb"))
        );
    }
}
