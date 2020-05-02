using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using MarketBazarKukharITEAFinallyProject.Models.Database;
using MarketBazarKukharITEAFinallyProject.Models.Entities;
using MarketBazarKukharITEAFinallyProject.Services;
using MarketBazarKukharITEAFinallyProject.Services.Interfaces;

namespace MarketBazarKukharITEAFinallyProject
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

            public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<IteaDbContext>(options =>
                options.UseSqlServer(
//#if DEBUG
                    Configuration.GetConnectionString("SQLConnectionString")
//#else
                    Configuration.GetConnectionString("SQLConnectionString_Release")
//#endif
                    )
            );

            services.AddTransient<IService<Buyers>, BuyersServices>();

            services.AddTransient<IService<Consumers>, ConsumersService>();

            services.AddMvc(options => { options.AllowEmptyInputInBodyModelBinding = true; })
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                })
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
