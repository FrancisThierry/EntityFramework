using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneTableCodeFirst.Migrations
{
    public partial class RemAnimalNickName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NickName",
                table: "Animals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "Animals",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
