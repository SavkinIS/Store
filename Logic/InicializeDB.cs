using Store.DataFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Store.AuUser;
using Store.Models;

namespace Store.Logic
{
    public class InicializeDB
    {
        /// <summary>
        /// First Initialize DataBase
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="roleManager"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task InitializeAsync(UserManager<User> userManager, 
                                                 RoleManager<IdentityRole> roleManager,
                                                 StoreContext context)
        {
            //Create first admin
            var admin = new User { UserName = "admin", Email = "admin@gmail.com" };
            string password = "Admin000!";
           
            //провкрка ролей, в случае отсутствия добавление
            if (await roleManager.FindByNameAsync(MyRoles.Admin) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(MyRoles.Admin));
            }
            if (await roleManager.FindByNameAsync(MyRoles.Maneger) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(MyRoles.Maneger));
            }
            if (await roleManager.FindByNameAsync(MyRoles.Customer) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(MyRoles.Customer));
            }

            //проверка на наличие пользователя с ником Админ, в случае отсутствие выполняет добавление еге 
            if (await userManager.FindByNameAsync(admin.UserName) == null)
            {
               
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, MyRoles.Admin);
                    context.SaveChanges();
                }
            }

          /*  var unit = new UnitOfWork();

            if (unit.Users.GetDataList().Any()) return;

            using (var trans = context.Database.BeginTransaction())
            {
               // foreach (var item in roles) context.Roles.Add(item);

                context.SaveChanges();

                trans.Commit();
            }
            */
        }

    }
}
