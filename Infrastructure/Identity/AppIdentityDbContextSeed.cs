using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Ashane",
                    Email = "ashane@test.com",
                    UserName = "ashane@test.com",
                    Address = new Address
                    {
                        FirstName = "Ashane",
                        LastName = "Alvis",
                        Street = "12 Street",
                        City = "New York",
                        State = "NY",
                        ZipCode = "10048"
                    }
                };

                await userManager.CreateAsync(user, "A$h@145");
            }
        }
    }
}
