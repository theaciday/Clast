using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clast.Data;
using Clast.Data.Interfaces;
using Clast.Data.Mocks;
using Clast.Data.Models;
using Clast.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Clast
{
    public class Startup
    {
        private readonly IConfigurationRoot _configuration;

        public Startup(IHostEnvironment host)
        {
            _configuration = new ConfigurationBuilder().SetBasePath(host.ContentRootPath).AddJsonFile("dbsettings.json")
                .Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<ILaptop,LaptopRepository>();
            services.AddTransient<ILaptopCategory, LaptopCategoryRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();

        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes=> {

                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "Laptop/{action}/{category?}", defaults:new { Controller = "Laptop", action = "List" });
                

            });
            

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDbContext content = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                DbObjects.Initial(content);


            }
           
        }
    }
}
