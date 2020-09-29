using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursesApp1.Container;
using CoursesApp1.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CoursesApp1
{
    public class Startup
    {
        private readonly IConfiguration conf;

        public Startup(IConfiguration conf) //to read configration from the appsetting 
        {
           
            this.conf = conf;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContextPool<dbContainer>(op => op.UseSqlServer(conf.GetConnectionString("mycon")));
            services.AddSession();

            services.AddScoped<ICourseRep, CourseRep>();
            services.AddScoped<ICategoryRep, CategoryRep>();
            services.AddScoped<ILevelRep, LevelRep>();
            services.AddScoped<IUserRep, UserRep>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseSession();
            app.UseEndpoints(a => a.MapDefaultControllerRoute());
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
