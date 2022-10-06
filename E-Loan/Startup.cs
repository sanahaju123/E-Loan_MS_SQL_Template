using E_Loan.BusinessLayer.Interfaces;
using E_Loan.BusinessLayer.Services;
using E_Loan.BusinessLayer.Services.Repository;
using E_Loan.DataLayer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace E_Loan
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


            services.AddDbContext<ELoanDbContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("ConnStr")));

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddControllersWithViews();
            services.AddSwaggerGen();
            services.AddHttpClient();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ILoanCustomerRepository, LoanCustomerRepository>();
            services.AddScoped<ILoanCustomerServices, LoanCustomerServices>();
            services.AddScoped<ILoanClerkRepository, LoanClerkRepository>();
            services.AddScoped<ILoanClerkServices, LoanClerkServices>();
            services.AddScoped<ILoanManagerRepository, LoanManagerRepository>();
            services.AddScoped<ILoanManagerServices, LoanManagerServices>();
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

                //app.UseHsts();
            }

            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Groceryemart");
            });
            app.UseHttpsRedirection();
        }
    }
}
