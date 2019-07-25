using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace TestArch.App.HealthChecks
{
    public class ExampleHealthCheck :
        IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken token = default)
        {
            var healthCheckResultHealthy = true;

            return healthCheckResultHealthy
                ? Task.FromResult(
                    HealthCheckResult.Healthy(
                        "The check indicates a healthy result."))
                : Task.FromResult(
                    HealthCheckResult.Unhealthy(
                        "The check indicates an unhealthy result."));
        }
    }
}
