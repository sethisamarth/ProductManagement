﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductManagement.Infrastructure.Data;

#nullable disable

namespace ProductManagement.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240822112242_SeedProductTable")]
    partial class SeedProductTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductManagement.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Latest model with advanced features and a sleek design.",
                            ImagePath = "https://placehold.co/600x400",
                            Price = 699.0,
                            Quantity = 100,
                            Title = "Smartphone"
                        },
                        new
                        {
                            Id = 2,
                            Description = "High-performance laptop suitable for gaming and work.",
                            ImagePath = "https://placehold.co/600x401",
                            Price = 1199.0,
                            Quantity = 50,
                            Title = "Laptop"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Noise-cancelling earbuds with long battery life.",
                            ImagePath = "https://placehold.co/600x402",
                            Price = 149.0,
                            Quantity = 200,
                            Title = "Wireless Earbuds"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Stylish smartwatch with health tracking features.",
                            ImagePath = "https://placehold.co/600x403",
                            Price = 199.0,
                            Quantity = 75,
                            Title = "Smartwatch"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Lightweight tablet with a high-resolution display.",
                            ImagePath = "https://placehold.co/600x404",
                            Price = 499.0,
                            Quantity = 80,
                            Title = "Tablet"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Portable speaker with powerful sound and long battery life.",
                            ImagePath = "https://placehold.co/600x405",
                            Price = 99.0,
                            Quantity = 150,
                            Title = "Bluetooth Speaker"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Next-gen console with immersive gameplay experience.",
                            ImagePath = "https://placehold.co/600x406",
                            Price = 399.0,
                            Quantity = 40,
                            Title = "Gaming Console"
                        },
                        new
                        {
                            Id = 8,
                            Description = "High-resolution camera perfect for photography enthusiasts.",
                            ImagePath = "https://placehold.co/600x407",
                            Price = 799.0,
                            Quantity = 60,
                            Title = "Camera"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Portable hard drive with large storage capacity.",
                            ImagePath = "https://placehold.co/600x408",
                            Price = 89.0,
                            Quantity = 120,
                            Title = "External Hard Drive"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Ultra HD Smart TV with built-in streaming services.",
                            ImagePath = "https://placehold.co/600x409",
                            Price = 999.0,
                            Quantity = 30,
                            Title = "Smart TV"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Wearable device for tracking fitness activities and health metrics.",
                            ImagePath = "https://placehold.co/600x410",
                            Price = 129.0,
                            Quantity = 90,
                            Title = "Fitness Tracker"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
