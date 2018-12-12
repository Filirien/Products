using Microsoft.EntityFrameworkCore.Migrations;

namespace Products.Data.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "Shampoos" });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Description" },
                values: new object[] { 2, "Fruits" });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Description" },
                values: new object[] { 3, "Vegetables" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "TypeId", "UserId" },
                values: new object[,]
                {
                    { 1, "Gernier", 1, 3 },
                    { 22, "Broccoli", 3, 1 },
                    { 21, "Melon", 3, 1 },
                    { 20, "Potato", 3, 1 },
                    { 19, "Garlic", 3, 2 },
                    { 18, "Cucumber", 3, 3 },
                    { 17, "Carrot", 3, 3 },
                    { 16, "Mandarin", 2, 1 },
                    { 15, "Mango", 2, 1 },
                    { 14, "Lemon", 2, 2 },
                    { 13, "Grape", 2, 2 },
                    { 12, "Grapefruit", 2, 2 },
                    { 11, "Cherry", 2, 2 },
                    { 10, "Avocado", 2, 3 },
                    { 9, "Banana", 2, 3 },
                    { 8, "ARGAN", 1, 1 },
                    { 7, "Wash & Go", 1, 1 },
                    { 6, "Shauma Nature", 1, 2 },
                    { 5, "Shauma", 1, 2 },
                    { 4, "Loreal", 1, 3 },
                    { 3, "Leganza", 1, 3 },
                    { 2, "Head & Shoulders", 1, 3 },
                    { 23, "Asparagus", 3, 1 },
                    { 24, "Fennel", 3, 1 }
                });
        }

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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
