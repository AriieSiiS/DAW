﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AUT02_05.Models;
using AUT02_05.Seeders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AUT02_05.Data
{
    public partial class DiccionarioContext : DbContext
    {
        public DiccionarioContext()
        {
        }

        public DiccionarioContext(DbContextOptions<DiccionarioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Espeng> Espengs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Espeng>().ToTable("Espeng", t => t.ExcludeFromMigrations());
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<AUT02_05.Models.Frases>? Frases { get; set; }
    }
}