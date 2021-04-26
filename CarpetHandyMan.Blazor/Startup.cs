using Blazored.Modal;
using CarpetHandyMan.Blazor.Data;
using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Blazor.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor
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
            services.AddHttpClient<ICarpetService, CarpetService>(client => client.BaseAddress = new Uri("https://localhost:44311/"));
            services.AddHttpClient<IRoomService, RoomService>(client => client.BaseAddress = new Uri("https://localhost:44311/"));
            services.AddHttpClient<IStaircaseService, StaircaseService>(client => client.BaseAddress = new Uri("https://localhost:44311/"));
            services.AddHttpClient<IClosetService, ClosetService>(client => client.BaseAddress = new Uri("https://localhost:44311/"));
            services.AddHttpClient<IRetailerService, RetailerService>(client => client.BaseAddress = new Uri("https://localhost:44311/"));

            services.AddBlazoredModal();
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<CarpetService>();
            services.AddSingleton<RoomService>();
            services.AddSingleton<StaircaseService>();
            services.AddSingleton<ClosetService>();
            services.AddSingleton<RetailerService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
