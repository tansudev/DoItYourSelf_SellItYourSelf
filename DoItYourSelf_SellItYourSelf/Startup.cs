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
using DoItYourSelf_SellItYourSelf.CORE.Service;
using DoItYourSelf_SellItYourSelf.SERVÝCE.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace DoItYourSelf_SellItYourSelf
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add 

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.Configure<CookiePolicyOptions>(options =>
            {

                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //Defined to use our database connection in each module
            services.AddDbContext<DIYSIYContext>(options =>
            {
                options.UseSqlServer("server=.; database=DIYSIYBlog; uid=sa; pwd=123;");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
  
            //The AddScoped method registers the service with a scoped lifetime, the lifetime of a single request.
            services.AddScoped(typeof(ICoreService<>), typeof(BaseService<>));
            //services.AddTransient(typeof(ICoreService<>), typeof(BaseService<>));
            //services.AddSingleton(typeof(ICoreService<>), typeof(BaseService<>));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            //Authentication configurations
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option => {
                option.Cookie.Name = "UserLoginCookie";
                option.LoginPath = "/Login/LoginPage"; });
            //Authorization configuration role ýnfo take from ClaimTypes.Role as string 
            services.AddAuthorization(option =>
            {
                var userAuthPolicyBuilder = new AuthorizationPolicyBuilder();
                option.DefaultPolicy = userAuthPolicyBuilder.RequireAuthenticatedUser().RequireClaim(ClaimTypes.Role).Build();
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
            app.UseCookiePolicy();
            app.UseRouting();
            app.UseHttpsRedirection();
            //Who you are?
            app.UseAuthentication();
            //Are you allowed?
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "area",
                   pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
               
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");   
            });

        }
    }
}
