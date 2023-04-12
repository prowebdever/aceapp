using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AceApp.Migrations
{
    public partial class AddPropertyClaim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttachedImages",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimId = table.Column<long>(type: "bigint", nullable: false),
                    ImageSrc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachedImages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PropertyClaims",
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
                    DescriptionOfLoss = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true),
                    PolicyType = table.Column<int>(type: "int", nullable: false),
                    PolicyNumber = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DayOfLoss = table.Column<DateTime>(type: "date", nullable: true),
                    InsuredLastNameOrBusinessName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    InsuredFirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    InsuredSamePropertyOwner = table.Column<bool>(type: "bit", nullable: false),
                    PropertyOwnerLastNameOrBusinessName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PropertyOwnerFirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PropertyOwnerState = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    PropertyOwnerZipCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    ClaimComments = table.Column<string>(type: "nvarchar(750)", maxLength: 750, nullable: true),
                    ContactShopName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactPhoneNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    IsReachAgreement = table.Column<bool>(type: "bit", nullable: false),
                    IsPermittedGatherMoreInfo = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyClaims", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PropertyClaim_AspNetUsers",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyClaims_UserId",
                table: "PropertyClaims",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttachedImages");

            migrationBuilder.DropTable(
                name: "PropertyClaims");
        }
    }
}
