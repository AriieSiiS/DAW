using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AUT03_02.Models;
using AUT03_02.Seeders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AUT02_05.Seeders;

namespace AUT03_02.Data
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
            SeederIdentity.SeederPrincipal(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}