using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using WebApi.Auth;

namespace WebApi
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
            JWTBasicPayload payloadSettings = GetJWTPayloadSettings();
            services.AddSingleton<JWTBasicPayload>(payloadSettings);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Angular Authentication Swagger API", Version = "v1" });
            });

            services.AddCors();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Angular Authentication Swagger API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseCors(
                options => options.WithOrigins(
                "http://localhost:4200").AllowAnyMethod().AllowAnyHeader()
            );

            //Disabled for development purpose; It should be enabled for production;
            //app.UseHttpsRedirection();
            app.UseMvc();
        }

        public JWTBasicPayload GetJWTPayloadSettings()
        {
            JWTBasicPayload settings = new JWTBasicPayload();

            settings.Key = Configuration["JwtPayloadSettings:key"];
            settings.Audience = Configuration["JwtPayloadSettings:audience"];
            settings.Issuer = Configuration["JwtPayloadSettings:issuer"];
            settings.MinutesToExpiration = Configuration["JwtPayloadSettings:minutesToExpiration"];

            return settings;
        }
    }
}
