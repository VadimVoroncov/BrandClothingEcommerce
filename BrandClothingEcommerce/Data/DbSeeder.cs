using BrandClothingEcommerce.Enum;
using Microsoft.AspNetCore.Identity;
using System.Data;

namespace BrandClothingEcommerce.Data
{
    public class DbSeeder
    {
        public static async Task SeedDefaultData(IServiceProvider service)
        {
            // менеджер пользователей
            var userMgr = service.GetService<UserManager<IdentityUser>>();
            // менеджер ролей
            var roleMgr = service.GetService<RoleManager<IdentityRole>>();

            // adding role  to user 
            // здесь нужно переёти в program.cs  и изменить 18 строку на добавление ролей
            await roleMgr.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleMgr.CreateAsync(new IdentityRole(Roles.User.ToString()));

            // create admin user
            var admin = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true
            };
            var userInDb = await userMgr.FindByEmailAsync(admin.Email);
            if (userInDb is null)
            {
                await userMgr.CreateAsync(admin, "Admin@123");
                await userMgr.AddToRoleAsync(admin, Roles.Admin.ToString());
            }
        }
    }
}
