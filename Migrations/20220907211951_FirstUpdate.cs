using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UCTprojecthub.Migrations
{
    public partial class FirstUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "UCTprojecthubUserStudentNumber",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "UCTprojecthubUserStudentNumber",
                table: "Themes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 7, 14, 19, 51, 129, DateTimeKind.Local).AddTicks(2019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 7, 14, 15, 28, 20, DateTimeKind.Local).AddTicks(8939));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "UCTprojecthubUserStudentNumber",
                table: "Topics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UCTprojecthubUserStudentNumber",
                table: "Themes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 7, 14, 15, 28, 20, DateTimeKind.Local).AddTicks(8939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 7, 14, 19, 51, 129, DateTimeKind.Local).AddTicks(2019));

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
        }
    }
}
