using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UCTprojecthub.Migrations
{
    public partial class UpdateTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36d26cb9-1bb6-404c-878a-69b164654029");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74570aa3-e2bf-4ceb-a9e0-d4e0a4c19a46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d950d9cc-5f61-4904-8e48-74ff16bec1b4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 7, 14, 46, 21, 882, DateTimeKind.Local).AddTicks(1589),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 7, 14, 19, 51, 129, DateTimeKind.Local).AddTicks(2019));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2022, 9, 7, 14, 19, 51, 129, DateTimeKind.Local).AddTicks(2019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 7, 14, 46, 21, 882, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36d26cb9-1bb6-404c-878a-69b164654029", "b6c02736-23e0-49ce-a368-e68ce245a154", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "74570aa3-e2bf-4ceb-a9e0-d4e0a4c19a46", "2fe844a1-9e8c-440e-8b71-bf39d96fbdf8", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d950d9cc-5f61-4904-8e48-74ff16bec1b4", "932c6d03-a00e-40e3-a8d8-8aec66929050", "Student", "STUDENT" });
        }
    }
}
