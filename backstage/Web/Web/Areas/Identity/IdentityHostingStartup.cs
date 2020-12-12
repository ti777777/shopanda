using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using Web.Areas.Identity.Data;
using Web.Data;

[assembly: HostingStartup(typeof(Web.Areas.Identity.IdentityHostingStartup))]
namespace Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            string connectionString = "server=127.0.0.1;user=root;password=abc123456789;database=auth";
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthDbContext>(options =>
                    options.UseMySql(
                        connectionString,
                        new MySqlServerVersion(new Version(8, 0, 19)), 
                        mySqlOptions => { })
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors());

                services.AddAuthentication(o =>
                {
                    o.DefaultScheme = IdentityConstants.ApplicationScheme;
                    o.DefaultSignInScheme = IdentityConstants.ExternalScheme;
                })
                .AddIdentityCookies(o => { });

                var identityServices = services.AddIdentityCore<ApplicationUser>(o =>
                {
                    o.Stores.MaxLengthForKeys = 128;
                    o.SignIn.RequireConfirmedAccount = true;
                }).AddDefaultTokenProviders()
                .AddEntityFrameworkStores<AuthDbContext>()
                .AddUserManager<MyUserManager>()
                .AddSignInManager();
                

                

                //services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<AuthDbContext>();
            });
        }
    }
}