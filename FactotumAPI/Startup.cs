using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using FactotumModels.Context;
using Microsoft.EntityFrameworkCore;

namespace FactotumAPI
{
    public class Startup
    {
        public Startup(/*IConfiguration configuration*/IHostingEnvironment env)
        {
            Configuration = env;


            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);


            using (var db = new FtDbContext())
            {
                db.Database.EnsureCreated();
                db.Database.Migrate();
            }

        }

        public IHostingEnvironment Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //Allow access for local developemtn environment
            //services.AddCors(c =>
            //{
            //    c.AddPolicy("AllowOrigin", options => options.WithOrigins(
            //        "https://localhost:44347",
            //        "http://localhost:44347",
            //        "https://factotum.azurewebsites.net", 
            //        "http://factotum.azurewebsites.net/"));
            //});

            services.AddCors();

            services.AddEntityFrameworkSqlite().AddDbContext<FtDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            //app.UseCors(options => options.AllowAnyOrigin());

            app.UseCors(options => options.WithOrigins(
                    "https://localhost:44347",
                    "http://localhost:44347",
                    "https://factotum.azurewebsites.net",
                    "http://factotum.azurewebsites.net/",
                    "https://factotumweb.azurewebsites.net",
                    "http://factotumweb.azurewebsites.net")
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
            );

            app.UseMvc();
        }
    }
}
