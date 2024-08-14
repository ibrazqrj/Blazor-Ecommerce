using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerceNEW.Migrations
{
    /// <inheritdoc />
    public partial class ProductVariants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "1 Monat" },
                    { 2, "3 Monate" },
                    { 3, "6 Monate" },
                    { 4, "Lifetime" },
                    { 5, "500'000" },
                    { 6, "1'000'000" },
                    { 7, "Normal" },
                    { 8, "XL" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Geniesse Hobbu mit verschiedenen Vorteile!", "Hobbu - VIP" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hobbu Rare Paket. Die Rares sind frei wählbar.", "Hobbu - Rare Pack" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Erhalte Diamanten für den Hobbu Client!", "Hobbu - Diamonds" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Erhalte Taler für den Hobbu Client!", "Hobbu - Taler" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Erhalte Taler für den Hobbu Client!", "Hobbu - Duckets" });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 1, 3.00m, 3.00m },
                    { 1, 2, 5.00m, 8.00m },
                    { 1, 3, 8.00m, 15.00m },
                    { 1, 4, 10.00m, 25.00m },
                    { 2, 7, 5.00m, 5.00m },
                    { 2, 8, 10.00m, 10.00m },
                    { 3, 5, 5.00m, 5.00m },
                    { 3, 6, 10.00m, 10.00m },
                    { 4, 5, 5.00m, 5.00m },
                    { 4, 6, 10.00m, 10.00m },
                    { 5, 5, 2.50m, 2.50m },
                    { 5, 6, 5.00m, 10.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "Geniesse Hobbu mit verschiedenen Vorteile für immer!", 9.99m, "Hobbu - VIP (Lifetime)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "Bis zu 8 Rares für das Hobbu Hotel (Frei wählbar!)", 7.99m, "Hobbu - Rare Pack (Mini)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "Erhalte 250 Diamonds für das Hobbu Hotel!", 6.99m, "Hobbu - Diamonds (250)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "Erhalte 1 Mio. Taler für das Hobbu Hotel!", 5m, "Hobbu - Taler (1 Mio.)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "Bis zu 10 Rares für das Hobbu Hotel (Frei wählbar!)", 2.50m, "Hobbu - Duckets (1 Mio.)" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 6, 2, "Bis zu 12 Rares für das Hobbu Hotel (Frei wählbar!)", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRrJnqIoVeMZDcHwyA2thmrTN4gsMZcqL6N40bI34kiOUhN_BHhyyqV1n3eMdvOgGDPtyI&usqp=CAU", 9.99m, "Hobbu - Rare Pack (Mid)" },
                    { 7, 2, "Bis zu 15 Rares für das Hobbu Hotel (Frei wählbar!)", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQHQ9MTAhD-PtZmuvI6W9tfQXFs7kvbZwFKbAlCzdAdCTdPLW98gyz-2IEM6LWmur0o6O4&usqp=CAU", 13m, "Hobbu - Rare Pack (Big)" },
                    { 8, 2, "Erhalte dein eigenes Badge und bestimmte Titel wie auch Beschreibung! (Badges in Verbindung zu Belästigung, Mobbing oder ausgeben eines Staffs sind verboten!)", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s", 2m, "Hobbu - VIP (1 Monat)" },
                    { 9, 1, "Geniesse Hobbu mit verschiedenen Vorteile für 3 Monate!", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s", 7.99m, "Hobbu - VIP (3 Monate)" },
                    { 10, 1, "Geniesse Hobbu mit verschiedenen Vorteile für ein halbes Jahr!", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s", 7.99m, "Hobbu - VIP (6 Monate)" }
                });
        }
    }
}
