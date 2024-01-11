using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PO03_01.Models;

namespace PO03_01.Seeders
{
    public class SeederIdentity
    {
        public static void SeederPrincipal(ModelBuilder modelBuilder)
        {
            List<IdentityRole> rolesList = SeederRole();
            List<AppUser> userList = SeederUser();
            HashPassword(userList);
            List<IdentityUserRole<string>> userRoleList = AssignRoles(rolesList, userList);

            modelBuilder.Entity<IdentityRole>().HasData(rolesList);
            modelBuilder.Entity<AppUser>().HasData(userList);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoleList);
        }
        public static List<AppUser> SeederUser()
        {
            List<AppUser> userList = new List<AppUser>
            {
                new AppUser
                {
                    UserName = "comercial1@musicstore.com",
                    NormalizedUserName = "COMERCIAL1@MUSICSTORE.COM",
                    Email = "comercial1@musicstore.com",
                    NormalizedEmail = "COMERCIAL1@MUSICSTORE.COM",
                    PasswordHash = "Asdf1234!",
                    FullName = "Usuario Normal Uno",
                    isActive = true,
                },
                new AppUser
                {
                    UserName = "comercial2@musicstore.com",
                    NormalizedUserName = "COMERCIAL2@MUSICSTORE.COM",
                    Email = "comercial2@musicstore.com",
                    NormalizedEmail = "COMERCIAL2@MUSICSTORE.COM",
                    PasswordHash = "Asdf1234!",
                    FullName = "Usuario Normal Dos",
                    isActive = true,
                },
                new AppUser
                {
                    UserName = "admin@musicstore.com",
                    NormalizedUserName = "ADMIN@MUSICSTORE.COM",
                    Email = "admin@musicstore.com",
                    NormalizedEmail = "ADMIN@MUSICSTORE.COM",
                    PasswordHash = "Asdf1234!",
                    FullName = "Usuario Admin",
                    isActive = true,
                }
            };
            return userList;
        }

        public static void HashPassword(List<AppUser> userList)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
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
                    Name = "Comercial",
                    NormalizedName = "COMERCIAL"
                },
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            };

            return rolesList;
        }
        public static List<IdentityUserRole<string>> AssignRoles(List<IdentityRole> rolesList, List<AppUser> userList)
        {
            List<IdentityUserRole<string>> userRoleList = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    UserId= userList[2].Id,
                    RoleId= rolesList[1].Id
                } 
            };
            return userRoleList;
        }
    }
}
