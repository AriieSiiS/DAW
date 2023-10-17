﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia_1.Data;

#nullable disable

namespace Persistencia_1.Migrations
{
    [DbContext(typeof(Persistencia_1Context))]
    [Migration("20231016093710_AddData5")]
    partial class AddData5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Persistencia_1.Models.Characters", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<decimal?>("Height")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("Retired")
                        .HasColumnType("bit");

                    b.Property<string>("Team")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("ID");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Age = 16,
                            Height = 1.64m,
                            Name = "Hinata Shoyo",
                            Position = "Wing Spiker",
                            Retired = false,
                            Team = "Karasuno High School"
                        },
                        new
                        {
                            ID = 2,
                            Age = 17,
                            Height = 1.84m,
                            Name = "Kageyama Tobio",
                            Position = "Setter",
                            Retired = false,
                            Team = "Karasuno High School"
                        },
                        new
                        {
                            ID = 3,
                            Age = 18,
                            Height = 1.87m,
                            Name = "Oikawa Tooru",
                            Position = "Setter",
                            Retired = true,
                            Team = "Aoba Johsai High School"
                        },
                        new
                        {
                            ID = 4,
                            Age = 17,
                            Height = 1.96m,
                            Name = "Tsukishima Kei",
                            Position = "Blocker",
                            Retired = false,
                            Team = "Karasuno High School"
                        },
                        new
                        {
                            ID = 5,
                            Age = 18,
                            Height = 1.88m,
                            Name = "Bokuto Koutarou",
                            Position = "Ace",
                            Retired = false,
                            Team = "Fukurodani Academy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
