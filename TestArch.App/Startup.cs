using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestArch.Api;
using TestArch.Domain;
using TestArch.Infra;

namespace TestArch.App
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMediatR(
                    typeof(IApiAssembly).Assembly,
                    typeof(IDomainAssembly).Assembly
                )
                .AddHealthChecksUI()
                .AddDomain()
                .AddInfra()
                .AddHealthCheckService()
                .AddMvc()
                .AddApplicationPart(typeof(IApiAssembly).Assembly)
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app
                .UseHealthChecksUI(config => config.UIPath = "/hc-ui")
                .AddHealthCheckConfigure()
                .UseHttpsRedirection()
                .UseMvc();
        }
    }
}