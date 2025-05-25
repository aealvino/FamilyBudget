using FamilyBudget.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FamilyBudget.Persistence.Seeders
{
    public static class RoleSeeder
    {
        public static async Task SeedRolesAsync(FamilyBudgetContext context)
        {
            if (!await context.Roles.AnyAsync())
            {
                var roles = new List<Role>
                {
                    new Role { Name = "Админ" },
                    new Role { Name = "Пользователь" },
                    new Role { Name = "Гость" },
                    new Role { Name = "Владелец семьи" }
                };

                context.Roles.AddRange(roles);
                await context.SaveChangesAsync();
            }
        }
    }
}
