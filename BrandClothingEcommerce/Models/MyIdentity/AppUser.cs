using Microsoft.AspNetCore.Identity;

namespace BrandClothingEcommerce.Models.MyIdentity
{
    public class AppUser : IdentityUser
    {
        public string? Name { get; set; }

        public string? ProfilePicture { get; set; }
    }
}
