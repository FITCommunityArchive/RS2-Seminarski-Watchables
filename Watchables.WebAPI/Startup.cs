using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.WebAPI.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Watchables.WebAPI.Database;
using Watchables.WebAPI.Services;

namespace Watchables.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            //Controllers and filters
            services.AddControllers(x => x.Filters.Add<ErrorFilter>());          
         
            //Swagger
            services.AddSwaggerGen(c =>{ c.SwaggerDoc("v1", new OpenApiInfo { Title = "Watchables API", Version = "v1" });});

            //Database
            services.AddDbContext<_160304Context>(options => options.UseSqlServer(Configuration.GetConnectionString("connectionString")));

            //AutoMapper
            services.AddAutoMapper();

            //Interface overrides
            services.AddScoped<IInitializeService, InitializeService>();
            services.AddScoped<ICinemasService, CinemasService>();
            services.AddScoped<IHallsService, HallsService>();
            services.AddScoped<IProductsService, ProductsService>();
            services.AddScoped<IMoviesService, MoviesService>();
            services.AddScoped<IAiringDayService, AiringDayService>();
            services.AddScoped<IAiringDaysOfCinemaService, AirinDaysOfCinemaService>();
            services.AddScoped<ICinemaDayMovieService, CinemaDayMovieService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

          
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
