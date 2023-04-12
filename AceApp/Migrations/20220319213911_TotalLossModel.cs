using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AceApp.Migrations
{
    public partial class TotalLossModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TotalLossClaims",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SubmittedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AceNo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Office = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    WorkPhone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    FaxNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClaimNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Deductible = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DayOfLoss = table.Column<DateTime>(type: "date", nullable: true),
                    InsuredLastNameOrBusinessName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    InsuredFirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    InsuredSameVehicleOwner = table.Column<bool>(type: "bit", nullable: false),
                    ClaimantLastNameOrBusinessName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ClaimantOwnerFirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ClaimComments = table.Column<string>(type: "nvarchar(750)", maxLength: 750, nullable: true),
                    VehicleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VehicleYear = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    VehicleMake = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VehicleModel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VehicleOdometer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VehicleState = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PowerOptions = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    Radios = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    Seats = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    Decors = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    Safetys = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    Wheels = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    Conveniences = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    Roofs = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    Paints = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    Trucks = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    Motorcycles = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalLossClaims", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TotalLossClaim_AspNetUsers",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TotalLossClaims_UserId",
                table: "TotalLossClaims",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TotalLossClaims");
        }
    }
}
