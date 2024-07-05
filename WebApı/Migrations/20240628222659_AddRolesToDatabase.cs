using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApı.Migrations
{
    public partial class AddRolesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e2667aa-e441-4a48-96a8-051f36189e5a", "748de039-acf7-4a79-840b-42f5a99910a7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e319006-a210-4d89-ae41-8d318840a6b2", "6490b1b9-3900-4010-8cfb-78a4841a16b0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d35a1a06-71e5-4a81-9da0-b9c7faa2ec26", "4c24e466-683e-42e0-be3f-d361fa08524e", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e2667aa-e441-4a48-96a8-051f36189e5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e319006-a210-4d89-ae41-8d318840a6b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d35a1a06-71e5-4a81-9da0-b9c7faa2ec26");
        }
    }
}
