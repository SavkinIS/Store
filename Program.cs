using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Store.AuUser;
using Store.DataFolder;
using Store.Logic;

namespace Store
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            var init = BuildWebHost(args);

            using (var scope = init.Services.CreateScope())
            {
                var s = scope.ServiceProvider;
                var c = s.GetRequiredService<StoreContext>();
                var userManager = s.GetRequiredService<UserManager<User>>();
                var rolesManager = s.GetRequiredService<RoleManager<IdentityRole>>();
                await InicializeDB.InitializeAsync(userManager, rolesManager, c);
            }

            init.Run();
            
        }

        public static IWebHost BuildWebHost(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
               .UseStartup<Startup>()
               .Build();
    }
}
