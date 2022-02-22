using CustomerServiceFluentAPIPractice.EntityFramework;
using CustomerServiceFluentAPIPractice.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using CustomerServiceFluentAPIPractice.Validation;

namespace CustomerServiceFluentAPIPractice
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
            //Dotnet core framework will allocate the memory for applicationDbContext class 
            services.AddDbContext<CustomerDbContext>(tm => tm.UseSqlServer(Configuration.GetConnectionString("MyConnectionString")));
            //per call object 
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            //Add to MVC - AddFluentValidation - Fluent will validate the data models before persisting them to the database
            services.AddMvc(
               t => { }).AddFluentValidation(
                   m => {
                       m.RegisterValidatorsFromAssemblyContaining<CustomerValidation>();
                   });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CustomerServiceFluentAPIPractice", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CustomerServiceFluentAPIPractice v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
