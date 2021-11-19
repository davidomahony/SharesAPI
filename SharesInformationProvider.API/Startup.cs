using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SharesInformationProvider.API.Fetchers;
using SharesInformationProvider.API.Services;
using SharesInformationProvider.Core;
using SharesInformationProvider.Core.AlphaVantage;
using System;

namespace SharesInformationProvider.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var mainUrl = Configuration["SharesApiProviderInformation:MainUrl"];

            services.AddHttpClient<IResultsFetcher<AlphaVantageStockFetchResult>, AlphaVantageStocksFetcher>(cl =>
                cl.BaseAddress = new Uri("SharesApiProviderInformation:AlphaVantageSharesUrl"));

            services.AddSingleton<BasicStocksService>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SharesInformationProvider.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SharesInformationProvider.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
