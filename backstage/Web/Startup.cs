using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Web.Helpers;
using Web.Models;

namespace Web
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
            //services.AddSingleton<SignInManager<IdentityUser>>();
            //services.AddSingleton<UserManager<IdentityUser>>();
            services.AddSingleton<JwtHelper>();
            services.AddControllersWithViews();
            services.AddRazorPages();

            //string connectionString = "server=host.docker.internal;user=root;password=1234;database=auth";
            string connectionString = "server=127.0.0.1;user=root;password=1234;database=auth";

            services.AddDbContext<shopContext>();

            services.AddDbContext<AuthDbContext>(config =>
                config.UseMySql(
                        connectionString,
                        new MySqlServerVersion(new Version(8, 0, 19)),
                        mySqlOptions => { })
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors());

            services.AddIdentity<IdentityUser, IdentityRole>(config =>
             {
                 config.Password.RequiredLength = 4;
                 config.Password.RequireDigit = false;
                 config.Password.RequireNonAlphanumeric = false;
                 config.Password.RequireUppercase = false;
             })
            .AddEntityFrameworkStores<AuthDbContext>()
            .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(config =>
            {
                config.Cookie.Name = "Identity.cookies";
                config.LoginPath = "/Account/Login";
            });

            //services.AddAuthentication("JWT")
            //        .AddJwtBearer("JWT", configs =>
            //        {
            //            var secretBytes = Encoding.UTF8.GetBytes(Constants.Secret);
            //            var keys = new SymmetricSecurityKey(secretBytes);

            //            configs.Events = new JwtBearerEvents()
            //            {
            //                OnMessageReceived = context =>
            //                {
            //                    if (context.Request.Query.ContainsKey("access_token"))
            //                    {
            //                        context.Token = context.Request.Query["access_token"];
            //                    }

            //                    return Task.CompletedTask;
            //                }
            //        };

            //        configs.TokenValidationParameters = new TokenValidationParameters()
            //        {
            //            ClockSkew = TimeSpan.Zero,
            //            ValidIssuer = Constants.Issuer,
            //            ValidAudience = Constants.Audiance,
            //            IssuerSigningKey = keys,
            //        };
            //});

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
