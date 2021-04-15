using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.infrastructure;
using CarpetHandyMan.infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan
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
            services.AddDbContext<CarpetContext>(opt =>
                opt.UseLazyLoadingProxies().UseSqlServer(("Server =./; Integrated Security = False; Database = CarpetHandyManDB"), b => b.MigrationsAssembly("CarpetHandyMan.Api")));
            services.AddScoped<IBuildingRepository, BuildingRepository>();
            services.AddScoped<ICarpetRepository, CarpetRepository>();
            services.AddScoped<IClosetRepository, ClosetRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IInstallerRepository, InstallerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IRetailerRepository, RetailerRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IStaircaseRepository, StaircaseRepository>();
            services.AddScoped<IStairRepository, StairRepository>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            RepoDb.SqlServerBootstrap.Initialize();

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
