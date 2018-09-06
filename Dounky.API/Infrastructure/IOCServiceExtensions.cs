using Dounky.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Dounky.API.Infrastructure
{
    public static class IOCServiceExtensions
    {
        public static IServiceCollection RegisterIOCContainer(this IServiceCollection services)
        {
            // configure DI for application services
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
