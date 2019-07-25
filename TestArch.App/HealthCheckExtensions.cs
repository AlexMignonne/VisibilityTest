using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using TestArch.App.HealthChecks;

namespace TestArch.App
{
    public static class HealthCheckExtensions
    {
        public static IServiceCollection AddHealthCheckService(
            this IServiceCollection services)
        {
            services
                .AddHealthChecks()
                .AddCheck<ExampleHealthCheck>("example_health_check");

            return services;
        }

        public static IApplicationBuilder AddHealthCheckConfigure(
            this IApplicationBuilder app)
        {
            return app.UseHealthChecks("/hc", new HealthCheckOptions
            {
                AllowCachingResponses = false,
                ResultStatusCodes =
                {
                    [HealthStatus.Healthy] = StatusCodes.Status200OK,
                    [HealthStatus.Degraded] = StatusCodes.Status200OK,
                    [HealthStatus.Unhealthy] = StatusCodes.Status503ServiceUnavailable
                },
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });
        }
    }
}
