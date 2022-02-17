using Microsoft.Extensions.DependencyInjection;
using Verivox.Contracts;

namespace Verivox.Services
{
    public static class ServiceExtensions
    {
        public static void AddVerivoxServices(this IServiceCollection services)
        {
            services.AddScoped<IConsumptionService, ConsumptionService>();
        }
    }
}
