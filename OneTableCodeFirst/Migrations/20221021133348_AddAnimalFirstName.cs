using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneTableCodeFirst.Migrations
{
    public partial class AddAnimalFirstName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Animals",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Animals");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Name" },
                values: new object[] { 1, "siamese", "Bill" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Name" },
                values: new object[] { 2, "siamese", "Boule" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Name" },
                values: new object[] { 3, "siamese", "Bale" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Name" },
                values: new object[] { 4, "siamese", "Belle" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Name" },
                values: new object[] { 5, "siamese", "Garfield" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Name" },
                values: new object[] { 6, "siamese", "Miss Teigne" });
        }
    }
}
