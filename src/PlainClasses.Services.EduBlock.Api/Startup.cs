using System;
using Autofac.Extensions.DependencyInjection;
using Hellang.Middleware.ProblemDetails;
using MicroserviceLibrary.Api.Configurations.Extensions;
using MicroserviceLibrary.Api.Utils;
using MicroserviceLibrary.Infrastructure.Databases;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PlainClasses.Services.EduBlock.Infrastructure.Sql;
using PlainClasses.Services.Identity.Api.Utils;

namespace PlainClasses.Services.EduBlock.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddSqlConfiguration(Configuration, Consts.DbConfigurationSection);
            services.AddDbContext<EduBlockContext>();
            services.AddScoped(typeof(IApplicationDbContext), typeof(EduBlockContext));
            
            services.AddControllers();
            services.AddSwagger();
           
            services.AddErrorHandler();
            
            return new AutofacServiceProvider(AutofacServiceExtension.CreateContainer(services, Configuration, 
                AssembliesConst.MigrationAssembly, AssembliesConst.ApplicationAssembly));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseProblemDetails();
            }

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
            app.UseSwagger();
            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint(Consts.ApiSwaggerUrl, Consts.ApiName);
            });
        }
    }
}
