using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UmsWeb.DataAccess.Migrations
{
    public partial class addUniqueIDinTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "subject6",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "subject7",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "subject8",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "UniqueId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Teachers");

            migrationBuilder.AddColumn<string>(
                name: "subject6",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "subject7",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "subject8",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
