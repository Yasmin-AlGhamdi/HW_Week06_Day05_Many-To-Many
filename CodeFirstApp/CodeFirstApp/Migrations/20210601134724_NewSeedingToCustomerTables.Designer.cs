﻿// <auto-generated />
using CodeFirstApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210601134724_NewSeedingToCustomerTables")]
    partial class NewSeedingToCustomerTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirstApp.Models.BranchModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Riyadh",
                            Area = "Alnakuli",
                            Name = "branch01"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Jeddah",
                            Area = "Huwilat",
                            Name = "branch02"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Jubail",
                            Area = "AlFanateer",
                            Name = "branch03"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Dammam",
                            Area = "Alnakheel",
                            Name = "branch04"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Khobar",
                            Area = "AlDharan",
                            Name = "branch05"
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Yasmin@hotmail.com",
                            FirstName = "Yasmin",
                            LastName = "AlGhamdi"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Lamya@hotmail.com",
                            FirstName = "Lamya",
                            LastName = "AlGhamdi"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Layan@hotmail.com",
                            FirstName = "Layan",
                            LastName = "AlGhamdi"
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}