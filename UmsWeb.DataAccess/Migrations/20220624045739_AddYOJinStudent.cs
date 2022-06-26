using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UmsWeb.DataAccess.Migrations
{
    public partial class AddYOJinStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YearOfJoining",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearOfJoining",
                table: "Students");
        }
    }
}
