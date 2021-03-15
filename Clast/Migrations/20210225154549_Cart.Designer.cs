﻿// <auto-generated />
using System;
using Clast.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clast.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210225154549_Cart")]
    partial class Cart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clast.Data.Models.Laptop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFavourite")
                        .HasColumnType("bit");

                    b.Property<int?>("LaptopCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("LongDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ShortDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LaptopCategoryId");

                    b.ToTable("Laptops");
                });

            modelBuilder.Entity("Clast.Data.Models.LaptopCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Clast.Data.Models.ShopCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LaptopId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ShopCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LaptopId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Clast.Data.Models.Laptop", b =>
                {
                    b.HasOne("Clast.Data.Models.LaptopCategory", "LaptopCategory")
                        .WithMany("Laptops")
                        .HasForeignKey("LaptopCategoryId");

                    b.Navigation("LaptopCategory");
                });

            modelBuilder.Entity("Clast.Data.Models.ShopCartItem", b =>
                {
                    b.HasOne("Clast.Data.Models.Laptop", "Laptop")
                        .WithMany()
                        .HasForeignKey("LaptopId");

                    b.Navigation("Laptop");
                });

            modelBuilder.Entity("Clast.Data.Models.LaptopCategory", b =>
                {
                    b.Navigation("Laptops");
                });
#pragma warning restore 612, 618
        }
    }
}