using System;
using ChangeLifestyle.Areas.Identity.Data;
using ChangeLifestyle.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

[assembly: HostingStartup(typeof(ChangeLifestyle.Areas.Identity.IdentityHostingStartup))]
namespace ChangeLifestyle.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ChangeLifestyleContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ChangeLifestyleContextConnection")));

                services.AddDefaultIdentity<ChangeLifestyleUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                    .AddEntityFrameworkStores<ChangeLifestyleContext>();
            });
        }
    }
}