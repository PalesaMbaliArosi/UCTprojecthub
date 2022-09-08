using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UCTprojecthub.Migrations
{
    public partial class UpdateThreee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cee5ad6-bf6f-460a-9f97-a2dfca1dfb71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "610d78cb-e5a2-4044-a8dd-d4c6df710162");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3794ddd-bff1-4ee8-95fc-cdbb6bc6be89");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 7, 15, 40, 10, 925, DateTimeKind.Local).AddTicks(1940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 7, 14, 46, 21, 882, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.CreateTable(
                name: "Allocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TopicId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Allocations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Allocations_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56fd662f-2d00-44b5-858d-8cb77daac917", "b43bb14d-6332-4b64-97ef-51cf36abd4e1", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd7492eb-7594-4ea1-a2be-ca3d90b03966", "c5df4aed-108d-4245-99e3-68fe04d7c1a0", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd8f195c-5a6a-44e8-837c-08917a4b5b1a", "dfb1260d-27df-445f-ab60-172f4db4a2cf", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Allocations_TopicId",
                table: "Allocations",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Allocations_UserId",
                table: "Allocations",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allocations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56fd662f-2d00-44b5-858d-8cb77daac917");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd7492eb-7594-4ea1-a2be-ca3d90b03966");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd8f195c-5a6a-44e8-837c-08917a4b5b1a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 7, 14, 46, 21, 882, DateTimeKind.Local).AddTicks(1589),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 7, 15, 40, 10, 925, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2cee5ad6-bf6f-460a-9f97-a2dfca1dfb71", "1589f6e6-8ad5-434f-adf0-82d05ff4ed39", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "610d78cb-e5a2-4044-a8dd-d4c6df710162", "0c43fadc-ba2f-44ce-aab0-d73f4e6d789f", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3794ddd-bff1-4ee8-95fc-cdbb6bc6be89", "ee0283d3-9680-45cf-89a6-80a35f861394", "Admin", "ADMIN" });
        }
    }
}
