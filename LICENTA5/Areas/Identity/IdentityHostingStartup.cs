using System;
using LICENTA5.Areas.Identity.Data;
using LICENTA5.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(LICENTA5.Areas.Identity.IdentityHostingStartup))]
namespace LICENTA5.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthDbContextConnection")));
               
                services.AddAuthentication().AddGoogle(options =>
                {
                    options.ClientId = "987673182070-009eil10filupkm7n33d73pc9u1jklc5.apps.googleusercontent.com";
                    options.ClientSecret = "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";
                    
                })
                .AddFacebook(options =>
                {
                    options.AppId = "4838067146306784";
                    options.AppSecret = "bb61d6141e5e0d0f045e833aa109857c";
                });


                services.AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.SignIn.RequireConfirmedEmail = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;

                    options.Lockout.MaxFailedAccessAttempts = 10;
                    options.User.RequireUniqueEmail = true;

                }).AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<AuthDbContext>()
                    .AddDefaultTokenProviders();
            });
        }
    }
}