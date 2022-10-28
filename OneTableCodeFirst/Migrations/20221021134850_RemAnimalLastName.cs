using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneTableCodeFirst.Migrations
{
    public partial class RemAnimalLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Animals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Animals",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
