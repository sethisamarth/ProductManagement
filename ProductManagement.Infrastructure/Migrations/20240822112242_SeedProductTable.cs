using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Date", "Description", "ImagePath", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, null, "Latest model with advanced features and a sleek design.", "https://placehold.co/600x400", 699.0, 100, "Smartphone" },
                    { 2, null, "High-performance laptop suitable for gaming and work.", "https://placehold.co/600x401", 1199.0, 50, "Laptop" },
                    { 3, null, "Noise-cancelling earbuds with long battery life.", "https://placehold.co/600x402", 149.0, 200, "Wireless Earbuds" },
                    { 4, null, "Stylish smartwatch with health tracking features.", "https://placehold.co/600x403", 199.0, 75, "Smartwatch" },
                    { 5, null, "Lightweight tablet with a high-resolution display.", "https://placehold.co/600x404", 499.0, 80, "Tablet" },
                    { 6, null, "Portable speaker with powerful sound and long battery life.", "https://placehold.co/600x405", 99.0, 150, "Bluetooth Speaker" },
                    { 7, null, "Next-gen console with immersive gameplay experience.", "https://placehold.co/600x406", 399.0, 40, "Gaming Console" },
                    { 8, null, "High-resolution camera perfect for photography enthusiasts.", "https://placehold.co/600x407", 799.0, 60, "Camera" },
                    { 9, null, "Portable hard drive with large storage capacity.", "https://placehold.co/600x408", 89.0, 120, "External Hard Drive" },
                    { 10, null, "Ultra HD Smart TV with built-in streaming services.", "https://placehold.co/600x409", 999.0, 30, "Smart TV" },
                    { 11, null, "Wearable device for tracking fitness activities and health metrics.", "https://placehold.co/600x410", 129.0, 90, "Fitness Tracker" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
