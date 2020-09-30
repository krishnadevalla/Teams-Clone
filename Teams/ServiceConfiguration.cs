using Fluxor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Reflection;

namespace Teams
{
    public static class ServiceConfiguration
    {
        public static void AddServices(this IServiceCollection services, IWebAssemblyHostEnvironment HostEnvironment)
        {
            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(HostEnvironment.BaseAddress) });
            services.AddFluxor(options =>
            {
                options.ScanAssemblies(Assembly.GetAssembly(typeof(Teams.Store.User.UserState)));
                options.UseReduxDevTools();
            });
        }
    }
}