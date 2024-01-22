﻿// <auto-generated />
using AUT02_03_Hybrid.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AUT02_03_Hybrid.Migrations
{
    [DbContext(typeof(NorthwindContext))]
    [Migration("20231020085416_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AUT02_03_Hybrid.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShipperID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShipperID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("AUT02_03_Hybrid.Models.Shipper", b =>
                {
                    b.Property<int>("ShipperID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShipperID"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("ShipperID");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("AUT02_03_Hybrid.Models.Company", b =>
                {
                    b.HasOne("AUT02_03_Hybrid.Models.Shipper", "Shipper")
                        .WithMany("Company")
                        .HasForeignKey("ShipperID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("AUT02_03_Hybrid.Models.Shipper", b =>
                {
                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}