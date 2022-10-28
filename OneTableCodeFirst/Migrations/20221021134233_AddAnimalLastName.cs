using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneTableCodeFirst.Migrations
{
    public partial class AddAnimalLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Animals",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Animals");
        }
    }
}
