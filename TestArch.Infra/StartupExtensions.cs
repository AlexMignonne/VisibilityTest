using Microsoft.Extensions.DependencyInjection;

using TestArch.Domain;

namespace TestArch.Infra
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services.AddTransient<ITestRepo, TestRepo>();

            return services;
        }
    }
}