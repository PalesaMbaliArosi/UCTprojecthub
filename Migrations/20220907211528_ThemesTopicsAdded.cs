using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UCTprojecthub.Migrations
{
    public partial class ThemesTopicsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f2d19dd-3016-438a-9d16-e71a857284f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3963466c-af8e-498c-b855-1dc3eb328506");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9925635b-b4fe-46de-bd4e-d89b33fdfcf8");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 7, 14, 15, 28, 20, DateTimeKind.Local).AddTicks(8939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 7, 14, 13, 26, 276, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(455)", maxLength: 455, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(455)", maxLength: 455, nullable: false),
                    DateCreated = table.Column<DateTime>(name: "Date Created", type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(name: "Date Updated", type: "datetime2", nullable: true),
                    StudentCount = table.Column<int>(type: "int", nullable: true),
                    UCTprojecthubUserStudentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Themes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(455)", maxLength: 455, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(455)", maxLength: 455, nullable: false),
                    isChosen = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(name: "Date Created", type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(name: "Date Updated", type: "datetime2", nullable: true),
                    ThemeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UCTprojecthubUserStudentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topics_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Topics_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "235b8e51-cab3-4a20-a4f9-211d4a9e58bf", "4ba5be22-7e3c-4aab-8461-5f9c11c78d9b", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "699c284b-6c5d-48a0-bc71-3ce4d69aaf11", "9e77e187-968a-4d43-b72e-e23c85be8ee7", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ea6024c-d28e-456d-b412-f2b4c28d5a8c", "2d2393c0-7fa2-4ec5-aa18-5d0d7f4cfd28", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Themes_UserId",
                table: "Themes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_ThemeId",
                table: "Topics",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_UserId",
                table: "Topics",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "235b8e51-cab3-4a20-a4f9-211d4a9e58bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "699c284b-6c5d-48a0-bc71-3ce4d69aaf11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ea6024c-d28e-456d-b412-f2b4c28d5a8c");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 7, 14, 13, 26, 276, DateTimeKind.Local).AddTicks(4988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 7, 14, 15, 28, 20, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f2d19dd-3016-438a-9d16-e71a857284f2", "2dffbeb4-5c5b-4ef6-8d3f-1972c6f5ceb6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3963466c-af8e-498c-b855-1dc3eb328506", "9163d6ea-2912-4411-8166-9df41370a4a5", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9925635b-b4fe-46de-bd4e-d89b33fdfcf8", "5e30174f-ce0b-47c1-8ee0-6975190c64d2", "Mentor", "MENTOR" });
        }
    }
}
