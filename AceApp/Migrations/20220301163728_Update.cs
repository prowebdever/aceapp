using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AceApp.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "UserDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Office",
                table: "UserDetail",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "UserDetail");

            migrationBuilder.DropColumn(
                name: "Office",
                table: "UserDetail");
        }
    }
}
