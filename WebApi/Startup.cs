﻿using System;
using BusinessLayer.Builders;
using BusinessLayer.Configs;
using BusinessLayer.Data;
using BusinessLayer.Mappers;
using BusinessLayer.ServiceInterfaces;
using BusinessLayer.Services;
using DomainModels.Models;
using DomainModels.Models.ClubEntities;
using DomainModels.Models.PlayerEntities;
using DomainModels.Models.TournamentEntities;
using DomainModels.Models.UserEntities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using RepositoryLayer.EntityFramework;
using RepositoryLayer.EntityFramework.Context;
using RepositoryLayer.Repository;
using Swashbuckle.AspNetCore.Swagger;

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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddCors();

            services.AddMvc().AddJsonOptions(options => 
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            });

            services.AddSingleton(Configuration);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });

            services.AddDbContext<FootballManagerContext>(options => options.UseSqlServer(Configuration.GetConnectionString("HomeConnection")));
            //services.AddDbContext<FootballManagerContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WorkConnection")));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = AuthOptions.ISSUER,
                        ValidateAudience = true,
                        ValidAudience = AuthOptions.AUDIENCE,
                        ValidateLifetime = true,
                        IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                        ValidateIssuerSigningKey = true
                    };
                });

            services.AddTransient<IRepository<User>, EfUserRepositiory>();
            services.AddTransient<IRepository<Club>, EfClubRepository>();
            services.AddTransient<IRepository<Player>, EfPlayerRepository>();
            services.AddTransient<IRepository<Tournament>, EfTournamentRepository>();
            services.AddTransient<IRepository<Match>, EfMatchRepository>();

            services.AddTransient<IUserRepository, EfUserRepositiory>();
            services.AddTransient<IClubRepository, EfClubRepository>();
            services.AddTransient<IPlayerRepository, EfPlayerRepository>();
            services.AddTransient<ITournamentRepository, EfTournamentRepository>();
            services.AddTransient<IMatchRepository, EfMatchRepository>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IClubService, ClubService>();
            services.AddTransient<IPlayerService, PlayerService>();
            services.AddTransient<ITournamentService, TournamentService>();
            services.AddTransient<IMatchService, MatchService>();

            services.AddTransient<IConfigItem<CountryNameMapper>, JsonConfigItem<CountryNameMapper>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider ser)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(builder => builder.AllowAnyOrigin());

            app.UseHttpsRedirection();


            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); });

            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
