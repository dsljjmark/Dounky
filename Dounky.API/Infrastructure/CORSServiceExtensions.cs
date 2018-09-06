using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Dounky.API.Infrastructure
{
    public static class CORSServiceExtensions
    {
        public static IServiceCollection AddCorsExtentions(this IServiceCollection services)
        {
            services.AddCors();
            return services;
        }

        public static IApplicationBuilder UseCorsExtentions(this IApplicationBuilder app)
        {
            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
            return app;
        }
    }
}
