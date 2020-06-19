using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
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
using Microsoft.IdentityModel.Tokens;
using MySchool.API.Mapper;
using MySchool.Data.Context;
using MySchool.Data.Entity;
using MySchool.Data.GenRepo;
using MySchool.Data.Interface;

namespace MySchool.API
{
    public class Startup
    {
        readonly string MyLocalOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string tokenAudience = Configuration.GetValue<string>("TokenAudiences");
            string tokenIssuer = Configuration.GetValue<string>("TokenIssuer");


            services.AddCors(options =>
            {
                options.AddPolicy(MyLocalOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("https://localhost:44304",
                                                          "https://localhost:5001",
                                                          "http://localhost:5000"
                                                          )
                                      .AllowAnyHeader()
                                      .AllowAnyMethod();
                                  });
            });

            services.AddSession(opt =>
            {
                opt.IdleTimeout = TimeSpan.FromMinutes(60);
                opt.Cookie.HttpOnly = true;
                opt.Cookie.IsEssential = true;
            });

            services.AddDbContext<MySchoolContext>(opt => opt.UseSqlite(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("MySchool.API")));

            services.AddIdentity<AppUser, UserRole>(opt => opt.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<MySchoolContext>()
                .AddDefaultTokenProviders();
            services.AddScoped(typeof(ICrud<>), typeof(Repository<>));
            //password policy should be more strict in prod 
            services.Configure<IdentityOptions>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequiredLength = 3;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
            });

            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            byte[] SecretKey = Encoding.ASCII.GetBytes(Configuration.GetValue<string>("TokenKey"));
            services.AddAuthentication(auth =>
            {
                auth.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(opt =>
                {
                    opt.RequireHttpsMetadata = false;
                    opt.SaveToken = true;
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(SecretKey),
                        ValidateIssuer = true,
                        ValidIssuer = tokenIssuer,// "https://localhost:44353",
                        ValidateAudience = true,
                        ValidAudience = tokenAudience,// "https://localhost:44353", 
                        RequireExpirationTime = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                    };
                });

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);


            services.AddControllers();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseCors(MyLocalOrigins);
            app.UseAuthorization();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
