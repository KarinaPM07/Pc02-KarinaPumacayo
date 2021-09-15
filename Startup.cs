using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Semana7PC02
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) //Registrar los servicios
        {
            services.AddControllersWithViews(); //administrara los controller
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //Sirve para configurar como deben ser utilizados los Services
        {
            if (env.IsDevelopment()) //si estamos en un ambiente de desarrollo
            {
                app.UseDeveloperExceptionPage(); //tiene que mostrarnos todas las trazas antes de que falle
            }
            else
            {
                app.UseExceptionHandler("/Home/Error"); //si no estamos en desarrollo va a mostrar una pagina de Error
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles(); //Es importante para las imagenes, estilos, java scritp, estos recursos luego seran guardados en wwwroot, las imagenes no van a ir en la carpeta Views

            app.UseRouting(); //

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
