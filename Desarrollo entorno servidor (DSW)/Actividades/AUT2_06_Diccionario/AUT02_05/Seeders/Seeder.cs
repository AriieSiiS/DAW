using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AUT02_05.Seeders
{
    public class Seeder
    {
        public static void SeederPrincipal(ModelBuilder modelBuilder)
        {
            List<IdentityRole> rolesList = SeederRole();
            List<IdentityUser> userList = SeederUser();
            HashPassword(userList);
            List<IdentityUserRole<string>> userRoleList = AssignRoles(rolesList, userList);

            modelBuilder.Entity<IdentityRole>().HasData(rolesList);
            modelBuilder.Entity<IdentityUser>().HasData(userList);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoleList);
        }
        public static List<IdentityUser> SeederUser()
        {
            List<IdentityUser> userList = new List<IdentityUser>
            {
                new IdentityUser
                {
                    UserName = "basic@diccionario.com",
                    NormalizedUserName = "BASIC@DICCIONARIO.COM",
                    Email = "basic@diccionario.com",
                    NormalizedEmail = "BASIC@DICCIONARIO.COM",
                    PasswordHash = "basic"
                },
                new IdentityUser
                {
                    UserName = "admin@diccionario.com",
                    NormalizedUserName = "ADMIN@DICCIONARIO.COM",
                    Email = "admin@diccionario.com",
                    NormalizedEmail = "ADMIN@DICCIONARIO.COM",
                    PasswordHash = "admin"
                },
                new IdentityUser
                {
                    UserName = "premium@diccionario.com",
                    NormalizedUserName = "PREMIUM@DICCIONARIO.COM",
                    Email = "premium@diccionario.com",
                    NormalizedEmail = "PREMIUM@DICCIONARIO.COM",
                    PasswordHash = "premium"
                }
            };

            return userList;
        }

        public static void HashPassword(List<IdentityUser> userList)
        {
            var passwordHasher = new PasswordHasher<IdentityUser>();
            foreach (var user in userList)
            {
                user.PasswordHash = passwordHasher.HashPassword(user, user.PasswordHash);
            }
        }

        public static List<IdentityRole> SeederRole()
        {
            List<IdentityRole> rolesList = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "basic",
                    NormalizedName = "BASIC"
                },
                new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "premium",
                    NormalizedName = "PREMIUM"
                }
            };

            return rolesList;
        }
        public static List<IdentityUserRole<string>> AssignRoles(List<IdentityRole> rolesList, List<IdentityUser> userList)
        {
            List<IdentityUserRole<string>> userRoleList = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    UserId = userList[0].Id,
                    RoleId = rolesList[0].Id
                },
                new IdentityUserRole<string>
                {
                    UserId = userList[1].Id,
                    RoleId = rolesList[1].Id
                },
                new IdentityUserRole<string>
                {
                    UserId= userList[2].Id,
                    RoleId= rolesList[2].Id
                } 
            };
            return userRoleList;
        }
    }
}
