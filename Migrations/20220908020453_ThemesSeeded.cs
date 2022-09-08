using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UCTprojecthub.Migrations
{
    public partial class ThemesSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                defaultValue: new DateTime(2022, 9, 7, 19, 4, 53, 295, DateTimeKind.Local).AddTicks(3406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 7, 15, 40, 10, 925, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "Date Created", "Date Updated", "Description", "StudentCount", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("1f0404ce-9c49-4f1c-b6f1-4e057e4f50c4"), new DateTime(2022, 9, 7, 19, 4, 53, 295, DateTimeKind.Local).AddTicks(5134), null, "Information relating to real-world application eCommerce in Cape Town", null, "eCommerce", null },
                    { new Guid("8d4a836a-d0eb-4ee6-9b82-8d4898ca9381"), new DateTime(2022, 9, 7, 19, 4, 53, 295, DateTimeKind.Local).AddTicks(5142), null, "An analysis of current encryption protocols implemented within South Africa", null, "Encryption", null },
                    { new Guid("8fc24d0e-aba3-4f4b-b082-8e49fe6c280c"), new DateTime(2022, 9, 7, 19, 4, 53, 295, DateTimeKind.Local).AddTicks(5140), null, "A study involving improvements to blockchain technology", null, "Blockchain", null },
                    { new Guid("d68f72a1-986a-457e-bc2c-8ca234d7dbf0"), new DateTime(2022, 9, 7, 19, 4, 53, 295, DateTimeKind.Local).AddTicks(5141), null, "Developments in security and the improvements to be expected in the future", null, "Security", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("1f0404ce-9c49-4f1c-b6f1-4e057e4f50c4"));

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("8d4a836a-d0eb-4ee6-9b82-8d4898ca9381"));

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("8fc24d0e-aba3-4f4b-b082-8e49fe6c280c"));

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("d68f72a1-986a-457e-bc2c-8ca234d7dbf0"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 7, 15, 40, 10, 925, DateTimeKind.Local).AddTicks(1940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 7, 19, 4, 53, 295, DateTimeKind.Local).AddTicks(3406));

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
        }
    }
}
