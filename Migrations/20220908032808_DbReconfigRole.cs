using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UCTprojecthub.Migrations
{
    public partial class DbReconfigRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2022, 9, 7, 20, 28, 7, 772, DateTimeKind.Local).AddTicks(3681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 7, 19, 4, 53, 295, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "Date Created", "Date Updated", "Description", "StudentCount", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("372d73db-85fb-4701-891e-3756cfcf2117"), new DateTime(2022, 9, 7, 20, 28, 7, 772, DateTimeKind.Local).AddTicks(5382), null, "A study involving improvements to blockchain technology", null, "Blockchain", null },
                    { new Guid("cb6a10ff-7813-449a-810a-bf6997244b5b"), new DateTime(2022, 9, 7, 20, 28, 7, 772, DateTimeKind.Local).AddTicks(5385), null, "An analysis of current encryption protocols implemented within South Africa", null, "Encryption", null },
                    { new Guid("d96d096c-7457-4971-b7bd-dbe8bdbb438f"), new DateTime(2022, 9, 7, 20, 28, 7, 772, DateTimeKind.Local).AddTicks(5378), null, "Information relating to real-world application eCommerce in Cape Town", null, "eCommerce", null },
                    { new Guid("f9652128-94de-45ce-a173-dd4fc7e1c203"), new DateTime(2022, 9, 7, 20, 28, 7, 772, DateTimeKind.Local).AddTicks(5384), null, "Developments in security and the improvements to be expected in the future", null, "Security", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("372d73db-85fb-4701-891e-3756cfcf2117"));

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("cb6a10ff-7813-449a-810a-bf6997244b5b"));

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("d96d096c-7457-4971-b7bd-dbe8bdbb438f"));

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("f9652128-94de-45ce-a173-dd4fc7e1c203"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 7, 19, 4, 53, 295, DateTimeKind.Local).AddTicks(3406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 7, 20, 28, 7, 772, DateTimeKind.Local).AddTicks(3681));

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
    }
}
