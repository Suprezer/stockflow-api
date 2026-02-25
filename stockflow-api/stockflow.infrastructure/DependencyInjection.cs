using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace stockflow.infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
