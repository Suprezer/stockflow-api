using Microsoft.Extensions.DependencyInjection;

namespace stockflow.application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            return services;
        }
    }
}