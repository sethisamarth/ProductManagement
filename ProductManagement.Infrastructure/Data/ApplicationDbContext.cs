using Microsoft.EntityFrameworkCore;
using ProductManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                    modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Title = "Smartphone",
                Description = "Latest model with advanced features and a sleek design.",
                Quantity = 100,
                Price = 699,
                ImagePath = "https://placehold.co/600x400"
            },
            new Product
            {
                Id = 2,
                Title = "Laptop",
                Description = "High-performance laptop suitable for gaming and work.",
                Quantity = 50,
                Price = 1199,
                ImagePath = "https://placehold.co/600x401"
            },
            new Product
            {
                Id = 3,
                Title = "Wireless Earbuds",
                Description = "Noise-cancelling earbuds with long battery life.",
                Quantity = 200,
                Price = 149,
                ImagePath = "https://placehold.co/600x402"
            },
            new Product
            {
                Id = 4,
                Title = "Smartwatch",
                Description = "Stylish smartwatch with health tracking features.",
                Quantity = 75,
                Price = 199,
                ImagePath = "https://placehold.co/600x403"
            },
            new Product
            {
                Id = 5,
                Title = "Tablet",
                Description = "Lightweight tablet with a high-resolution display.",
                Quantity = 80,
                Price = 499,
                ImagePath = "https://placehold.co/600x404"
            },
            new Product
            {
                Id = 6,
                Title = "Bluetooth Speaker",
                Description = "Portable speaker with powerful sound and long battery life.",
                Quantity = 150,
                Price = 99,
                ImagePath = "https://placehold.co/600x405"
            },
            new Product
            {
                Id = 7,
                Title = "Gaming Console",
                Description = "Next-gen console with immersive gameplay experience.",
                Quantity = 40,
                Price = 399,
                ImagePath = "https://placehold.co/600x406"
            },
            new Product
            {
                Id = 8,
                Title = "Camera",
                Description = "High-resolution camera perfect for photography enthusiasts.",
                Quantity = 60,
                Price = 799,
                ImagePath = "https://placehold.co/600x407"
            },
            new Product
            {
                Id = 9,
                Title = "External Hard Drive",
                Description = "Portable hard drive with large storage capacity.",
                Quantity = 120,
                Price = 89,
                ImagePath = "https://placehold.co/600x408"
            },
            new Product
            {
                Id = 10,
                Title = "Smart TV",
                Description = "Ultra HD Smart TV with built-in streaming services.",
                Quantity = 30,
                Price = 999,
                ImagePath = "https://placehold.co/600x409"
            },
            new Product
            {
                Id = 11,
                Title = "Fitness Tracker",
                Description = "Wearable device for tracking fitness activities and health metrics.",
                Quantity = 90,
                Price = 129,
                ImagePath = "https://placehold.co/600x410"
            }
        );

        }
    }
}
