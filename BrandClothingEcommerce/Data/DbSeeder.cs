using BrandClothingEcommerce.Models.MyIdentity;
using Microsoft.AspNetCore.Identity;


namespace BrandClothingEcommerce.Data
{
    public static class DbSeeder
    {
        public static async Task SeedDefaultData(IServiceProvider service)
        {
            // Исходные роли
            var userMgr = service.GetService<UserManager<AppUser>>();
            var roleMgr = service.GetService<RoleManager<IdentityRole>>();
            // здесь нужно переёти в program.cs  и изменить 18 строку на добавление ролей
            await roleMgr.CreateAsync(new IdentityRole(Enum.Roles.Admin.ToString()));
            await roleMgr.CreateAsync(new IdentityRole(Enum.Roles.User.ToString()));

            // создание администратора
            var admin = new AppUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                Name = "admin",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            var userInDb = await userMgr.FindByEmailAsync(admin.Email);
            if (userInDb is null)
            {
                await userMgr.CreateAsync(admin, "Admin@123");
                await userMgr.AddToRoleAsync(admin, Enum.Roles.Admin.ToString());
            }
        }
    }
}
