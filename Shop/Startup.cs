using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Lucky.Date;
using Lucky.Date.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lucky.Date.Repository;
using Lucky.Date.Models;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Lucky
{
    public class Startup
    {

        private IConfigurationRoot _confsting;

        //Кажется IHostingEnvironment, его заменили IHostEnvironment
        public Startup(IHostEnvironment hostEnv)
        {
            _confsting = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSession();

            services.AddDbContext<AppDbContent>(options => options.UseSqlServer(_confsting.GetConnectionString("DefaultConnection")));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
             .AddCookie(options =>
             {
                 options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                 options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
             });

            services.AddTransient<IAllPets,PetRepository>();
            services.AddTransient<IPetsCategory, CategoryRepository>();

            services.AddTransient<IAllOrders, OrdersRepository>();
            services.AddTransient<IAllNews, NewsRepository>();

            services.AddMvc(option => option.EnableEndpointRouting = false);

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();         
            services.AddMemoryCache();
         
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseAuthentication();    // аутентификация
            app.UseAuthorization();     // авторизация
            app.UseMvc(routes => {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "Course/{action}/{category?}",defaults: new {Controller= "Course",action="List" });
            });
           

            
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDbContent content = scope.ServiceProvider.GetRequiredService<AppDbContent>();
                DBobjects.initial(content);
            }

          
        }
    }
}
