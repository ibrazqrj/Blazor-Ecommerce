using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerceNEW.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Geniesse Hobbu mit verschiedenen Vorteile.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s", 9.99m, "Hobbu - VIP" },
                    { 2, "Bis zu 10 Rares für das Hobbu Hotel (Frei wählbar!)", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYy9p1iZa44jfYqXC2NNBU1e4QbUtW5g9xeQ&s", 7.99m, "Hobbu - Rare Pack" },
                    { 3, "Erhalte 250 Diamonds für das Hobbu Hotel!", "https://scontent-zrh1-1.xx.fbcdn.net/v/t39.30808-6/274978441_10158590467262963_5370902555679068282_n.png?_nc_cat=106&ccb=1-7&_nc_sid=127cfc&_nc_ohc=vOYzWEKGu0kQ7kNvgFk_LTV&_nc_ht=scontent-zrh1-1.xx&oh=00_AYByiUjSlVZghuOJ4fOKuQ2kWmBxsqzil7uPqguD6lFW6A&oe=66BFCF27", 6.99m, "Hobbu - Diamonds (250)" }
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
        }
    }
}
