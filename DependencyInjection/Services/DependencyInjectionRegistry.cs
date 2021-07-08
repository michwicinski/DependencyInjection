using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public static class DependencyInjectionRegistry
    {
        public static IServiceCollection AddMyServices(this IServiceCollection services)
        {
            services.AddSingleton<ISingletonOperation, SingletonOperation>();
            services.AddScoped<IScopedOperation, ScopedOperation>();
            services.AddTransient<ITransientOperation, TransientOperation>();
            services.AddTransient<IMyService, MyService>();

            return services;
        }
    }
}
