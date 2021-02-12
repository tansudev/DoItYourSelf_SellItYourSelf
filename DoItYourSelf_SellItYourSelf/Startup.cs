using Microsoft.AspNetCore.Builder;
using DoItYourSelf_SellItYourSelf.MODEL.Context;
using DoItYourSelf_SellItYourSelf.CORE.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
            services.AddMvc(option => option.EnableEndpointRouting = false);

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseRouting();

          
        }
    }
}
