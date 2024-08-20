using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerceNEW.Migrations
{
    /// <inheritdoc />
    public partial class FeaturedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Pakete");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Währung");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Featured", "ImageUrl" },
                values: new object[] { true, "https://i.imgur.com/ZhRJNod.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Featured", "ImageUrl", "Title" },
                values: new object[] { false, "https://i.imgur.com/UQjhDCy.png", "Hobbu - Rare Paket" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Featured", "ImageUrl", "Title" },
                values: new object[] { true, "https://i.imgur.com/7mq1YzD.png", "Hobbu - Diamanten" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Featured", "ImageUrl" },
                values: new object[] { false, "https://i.imgur.com/qgAsu9u.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Featured", "ImageUrl" },
                values: new object[] { false, "https://cdn.discordapp.com/attachments/1266160134665670797/1275056899997564952/DucketsBanner.png?ex=66c480c6&is=66c32f46&hm=c10369c0a81232057f634f538999324158777fa771527d1ef7b4dbfbf253b294&" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Featured",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Packs");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Currencies");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Title" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYy9p1iZa44jfYqXC2NNBU1e4QbUtW5g9xeQ&s", "Hobbu - Rare Pack" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Title" },
                values: new object[] { "https://scontent-zrh1-1.xx.fbcdn.net/v/t39.30808-6/274978441_10158590467262963_5370902555679068282_n.png?_nc_cat=106&ccb=1-7&_nc_sid=127cfc&_nc_ohc=vOYzWEKGu0kQ7kNvgFk_LTV&_nc_ht=scontent-zrh1-1.xx&oh=00_AYByiUjSlVZghuOJ4fOKuQ2kWmBxsqzil7uPqguD6lFW6A&oe=66BFCF27", "Hobbu - Diamonds" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://media.karousell.com/media/photos/products/2015/11/22/habbo_coins_10cents_1448207029_42efc8a0.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSAGmXZnYohNKEHtj_59MTJg4N-Xo4uM1KK2A&s");
        }
    }
}
