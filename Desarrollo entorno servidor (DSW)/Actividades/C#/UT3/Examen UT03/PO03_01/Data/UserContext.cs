using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PO03_01.Models;
using PO03_01.Seeders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PO03_01.Data
{
    public partial class UserContext : IdentityDbContext<AppUser>
    {
        public UserContext()
        {

        }

        public UserContext(DbContextOptions<UserContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //OnModelCreatingPartial(modelBuilder);
            base.OnModelCreating(modelBuilder);
            SeederIdentity.SeederPrincipal(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}