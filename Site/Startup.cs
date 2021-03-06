using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Aplication.Helpers;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Domain.Configuration;
using Infrastructure.Configuration;
using AutoMapper;
using Aplication.Base.Mapping;
using Aplication.Service;

namespace Site
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
            services.AddControllersWithViews();
            services.AddDbContext<ApplicationContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("ConnectionDefault")), ServiceLifetime.Transient);

            services.AddScoped<IDbContext, ApplicationContext>();
            services.AddScoped<IUnitOfWorkRepository, UnitOfWorkRepository>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<ITbl_Cliente_Service, Cliente_Service>();
            services.AddTransient<IVisitas_Al_Medico_Service, Visitas_Al_Medico_Service>();

            var initialMapper = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new EmployeeMapping());
                opt.AddProfile(new ClientMapping());
                opt.AddProfile(new Visitas_Al_Medico_Mapping());
                
            });
            services.AddSingleton(initialMapper.CreateMapper());
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
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
