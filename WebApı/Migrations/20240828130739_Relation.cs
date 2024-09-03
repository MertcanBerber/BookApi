using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApı.Migrations
{
    public partial class Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0299709a-4795-459d-8e1a-0b22f3425c5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "593be2c9-9c79-4672-86e7-6e714e652b56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5f44a6c-c9f2-4707-83aa-cb01f6150b82");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "25e1d3be-729c-47ba-9d9f-1b9df9bd2430", "52d1fb1d-cdb2-4633-bdd0-48c71d5404f9", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65dd739a-321d-4da0-89e2-f5f901ad7281", "840ef8e9-f726-40c9-bd27-f7b978082888", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e46eadb6-2e32-454f-a577-47e9135be161", "ccfb832d-a697-4dce-8eb4-e9e3c807252d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25e1d3be-729c-47ba-9d9f-1b9df9bd2430");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65dd739a-321d-4da0-89e2-f5f901ad7281");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46eadb6-2e32-454f-a577-47e9135be161");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0299709a-4795-459d-8e1a-0b22f3425c5b", "e8559a24-f55d-4baf-b7bc-70f3d707cf3c", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "593be2c9-9c79-4672-86e7-6e714e652b56", "a9dba92c-32d5-4e71-bfd5-9e1d7cf24a11", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5f44a6c-c9f2-4707-83aa-cb01f6150b82", "01bd51d2-4c8a-4be4-9ca4-92a54e9d4adc", "User", "USER" });
        }
    }
}
