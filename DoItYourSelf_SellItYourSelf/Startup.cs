using Microsoft.AspNetCore.Builder;
using DoItYourSelf_SellItYourSelf.MODEL.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace DoItYourSelf_SellItYourSelf
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add 
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)

            services.AddDbContext<DIYSIYContext>(options =>
            {
                options.UseSqlServer("server=.; database=DIYSIYProject; uid=sa; pwd=123;");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
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
               
            }
            
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
