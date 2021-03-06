using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using StoreHood.Api.Config;
using StoreHood.Api.CrossCutting;
using StoreHood.Api.DataAccess;
using StoreHood.Api.DataAccess.Contracts;

namespace StoreHoodApi
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
            services.AddScoped<IStoreHoodDBContext, StoreHoodDBContext>();
            services.AddDbContext<StoreHoodDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("shdb")));
            
            //Podr�amos crear varios registros de servicios, por ejemplo si las cadenas de conexion fueran distintas, las podr�amos pasar como par�metro.
            IocRegister.AddRegistration(services);
            SwaggerConfig.AddRegistration(services);
            
            //Esta etiqueta siempre debe ser la �ltima.
            services.AddControllers();
            //services.AddMvc();

        }
      

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            SwaggerConfig.AddRegistration(app);
            //app.UseMvc();

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
