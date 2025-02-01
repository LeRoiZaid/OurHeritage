using Microsoft.Extensions.DependencyInjection;
using OurHeritage.Service.Implementations;
using OurHeritage.Service.Interfaces;
using System.Reflection;

namespace OurHeritage.Service
{
    public static class ModuleServiceDependencies
    {
        public static void AddServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddMemoryCache();


            /// Register automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
