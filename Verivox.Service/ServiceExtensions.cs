using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verivox.Services;
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
