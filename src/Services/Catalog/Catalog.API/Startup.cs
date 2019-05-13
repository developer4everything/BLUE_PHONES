using System;
using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Catalog.Domain.Interfaces;
using Catalog.Infrastructure.Context;
using Catalog.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Catalog.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        readonly String AllowAllOrigins = "_allowAllOrigins";

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(AllowAllOrigins,
                    builder =>
                    {
                        builder.AllowAnyOrigin();
                    });
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1.0.0", new Info
                {
                    Title = "Blue Phones API",
                    Version = "1.0.0",
                    Description = "This is the Blue Phones API.",
                    Contact = new Contact { Email = "jesusgonzalezrodriguez@gmail.com" }
                });
            });

            services.AddEntityFrameworkSqlServer()
                .AddDbContext<CatalogContext>(options =>
                    {
                        options.UseSqlServer(Configuration.GetConnectionString("BluePhonesConnection"),
                            sqlOptions =>
                                sqlOptions.MigrationsAssembly(typeof(Startup).GetTypeInfo().Assembly.GetName().Name));
                    }
            );

            // Register our services with Autofac container.
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<CatalogRepository>().As<ICatalogRepository>();
            containerBuilder.Populate(services);

            // Create the IServiceProvider based on the container.
            var container = containerBuilder.Build();
            return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(AllowAllOrigins);
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1.0.0/swagger.json", "Blue Phones API v1.0.0");
            });
        }
    }
}
