using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerceNEW.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Geniesse Hobbu mit verschiedenen Vorteile für immer!", "Hobbu - VIP (Lifetime)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Bis zu 8 Rares für das Hobbu Hotel (Frei wählbar!)", "Hobbu - Rare Pack (Mini)" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 3, "Erhalte 1 Mio. Taler für das Hobbu Hotel!", "https://media.karousell.com/media/photos/products/2015/11/22/habbo_coins_10cents_1448207029_42efc8a0.jpg", 5m, "Hobbu - Taler (1 Mio.)" },
                    { 5, 3, "Bis zu 10 Rares für das Hobbu Hotel (Frei wählbar!)", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSAGmXZnYohNKEHtj_59MTJg4N-Xo4uM1KK2A&s", 2.50m, "Hobbu - Duckets (1 Mio.)" },
                    { 6, 2, "Bis zu 12 Rares für das Hobbu Hotel (Frei wählbar!)", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRrJnqIoVeMZDcHwyA2thmrTN4gsMZcqL6N40bI34kiOUhN_BHhyyqV1n3eMdvOgGDPtyI&usqp=CAU", 9.99m, "Hobbu - Rare Pack (Mid)" },
                    { 7, 2, "Bis zu 15 Rares für das Hobbu Hotel (Frei wählbar!)", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQHQ9MTAhD-PtZmuvI6W9tfQXFs7kvbZwFKbAlCzdAdCTdPLW98gyz-2IEM6LWmur0o6O4&usqp=CAU", 13m, "Hobbu - Rare Pack (Big)" },
                    { 8, 2, "Erhalte dein eigenes Badge und bestimmte Titel wie auch Beschreibung! (Badges in Verbindung zu Belästigung, Mobbing oder ausgeben eines Staffs sind verboten!)", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s", 2m, "Hobbu - VIP (1 Monat)" },
                    { 9, 1, "Geniesse Hobbu mit verschiedenen Vorteile für 3 Monate!", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s", 7.99m, "Hobbu - VIP (3 Monate)" },
                    { 10, 1, "Geniesse Hobbu mit verschiedenen Vorteile für ein halbes Jahr!", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s", 7.99m, "Hobbu - VIP (6 Monate)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Geniesse Hobbu mit verschiedenen Vorteile.", "Hobbu - VIP" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Bis zu 10 Rares für das Hobbu Hotel (Frei wählbar!)", "Hobbu - Rare Pack" });
        }
    }
}
