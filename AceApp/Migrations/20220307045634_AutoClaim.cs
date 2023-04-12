using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AceApp.Migrations
{
    public partial class AutoClaim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoReview");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "UserDetail",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "UserDetail",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Office",
                table: "UserDetail",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "UserDetail",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "UserDetail",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                table: "UserDetail",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Extension",
                table: "UserDetail",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "UserDetail",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "UserDetail",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Avtar",
                table: "UserDetail",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AutoClaims",
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
                    LossType = table.Column<int>(type: "int", nullable: false),
                    PolicyNumber = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Deductible = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DayOfLoss = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsuredLastNameOrBusinessName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    InsuredFirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    InsuredSameVehicleOwner = table.Column<bool>(type: "bit", nullable: false),
                    VehicleOwnerLastNameOrBusinessName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    VehicleOwnerFirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ClaimComments = table.Column<string>(type: "nvarchar(750)", maxLength: 750, nullable: true),
                    VehicleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VehicleYear = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    VehicleMake = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VehicleModel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VehicleOdometer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
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
                    table.PrimaryKey("PK_AutoClaims", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AutoClaim_AspNetUsers",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutoClaims_UserId",
                table: "AutoClaims",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoClaims");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "UserDetail",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "UserDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Office",
                table: "UserDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "UserDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "UserDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                table: "UserDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Extension",
                table: "UserDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "UserDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "UserDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Avtar",
                table: "UserDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AutoReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachUrl1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AttachUrl2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AttachUrl3 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AttachUrl4 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AttachUrl5 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ClaimNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateOfLoss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deductible = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DescriptionOfLoss = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    InsuredBusiness = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InsuredPersonFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InsuredPersonLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsReachAgreement = table.Column<bool>(type: "bit", nullable: false),
                    LossType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Odometer = table.Column<int>(type: "int", nullable: false),
                    OfficeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OfficeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PolicyNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShopName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubmittedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubmittedByEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubmittedByExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubmittedByFax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubmittedByPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VechieOwnerBusiness = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VechieOwnerPersonFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VechieOwnerPersonLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VehicleBodyStyle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VehicleMake = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VehicleVINNnumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VehicleYear = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoReview", x => x.Id);
                });
        }
    }
}
