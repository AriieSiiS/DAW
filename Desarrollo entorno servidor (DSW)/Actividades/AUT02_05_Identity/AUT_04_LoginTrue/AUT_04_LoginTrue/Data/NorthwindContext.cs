﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using AUT_04_LoginTrue.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AUT_04_LoginTrue.Data;

public partial class NorthwindContext : IdentityDbContext
{
    public NorthwindContext(DbContextOptions<NorthwindContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Supplier>().ToTable("Suppliers", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<Characters>().HasData(


);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}