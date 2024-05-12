using Microsoft.AspNetCore.Identity;

namespace IMS.web.Data
{
    public class DataSeeding
    {
        public static async Task InitilizeAsync(IServiceProvider serviceProvider)
        {
            var _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] Roles = { "SuperAdmin", "Admin", "Counter", "Store", "Public" };

            foreach (var role in Roles)
            {
                if(!await _roleManager.RoleExistsAsync(role))
                {
                    await _roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}
