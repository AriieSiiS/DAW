using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AUT02_05.Models;
using AUT02_05.Seeders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AUT02_05.Data
{
    public partial class UserContext : IdentityDbContext
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
            Seeder.SeederPrincipal(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}