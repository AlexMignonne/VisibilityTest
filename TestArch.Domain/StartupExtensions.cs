using Microsoft.Extensions.DependencyInjection;
using TestArch.Domain.UseCases;

namespace TestArch.Domain
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddDomain(
            this IServiceCollection services)
        {
            services
                .AddTransient<TestUseCase>();

            return services;
        }
    }
}