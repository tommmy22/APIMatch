using APIMatch.EquipeDBContext;
using APIMatch.Extensions;
using APIMatch.Models;
using APIMatch.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace APIMatch
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
            services.AddDbContext<TeamContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AzureConnection")));

            services.AddIdentity<User, Role>(options => options.Password.RequireUppercase = true)
                .AddEntityFrameworkStores<TeamContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IChampionshipRepository, ChampionshipRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<IGameRepository, GameRepository>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddSwagger();

            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services
                .AddSwaggerGen(setupAction =>
                {
                    setupAction.SwaggerDoc("APIMatch.APIOpenSpecification", new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = "APIMatch",
                        Version = "0.1"
                    });

                    var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

                    setupAction.IncludeXmlComments(xmlCommentsFullPath);
                });

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", p =>
                {
                    p.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("AllowAll");

            app.UseSwagger();

            app.UseSwaggerUI(setupAction =>
            {
                setupAction.SwaggerEndpoint("/swagger/APIMatch.APIOpenSpecification/swagger.json", "Bienvenue sur mon API Match");
                setupAction.RoutePrefix = string.Empty;
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
