using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyOnlineBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineBooks
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();


            //This service is added, connection to the connection string that we created in OnlineBooksDBContext class and the OnlineBooksConnection string connection created in appsettings.json            
            services.AddDbContext<OnlineBooksDBContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:OnlineBooksConnection"]);
            });

            services.AddScoped<IBooksRepository, EFBooksRepository>();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                //Create Endpoints to make navigation in url easier and look neater 
                endpoints.MapControllerRoute(
                    "categorypage",
                    "{category}/{page:int}",
                    new { Controller = "Home", action = "Index" }
                    );

                endpoints.MapControllerRoute(
                    "Bookcategorypage",
                    "Books/{category}/{page:int}",
                    new { Controller = "Home", action = "Index" }
                    );

                endpoints.MapControllerRoute(
                    "pagination",
                    //display urls as /P1, /P2, /P3, etc. 
                    "P{page}",
                    new { Controller = "Home", action = "Index" });

                endpoints.MapControllerRoute(
                    "page",
                    "{page:int}",
                    new { Controller = "Home", action = "Index" }
                    );

                endpoints.MapControllerRoute(
                    "category",
                    "{category}",
                    new { Controller = "Home", action = "Index", page = 1 }
                    );

                endpoints.MapDefaultControllerRoute();
            });

            //Seed data (list of 13 hardcoded books and their information) 
            SeedData.EnsurePopulated(app);
        }
    }
}
