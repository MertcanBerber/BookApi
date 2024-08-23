using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApı.Migrations
{
    public partial class cls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ec29942-210f-4e1f-8c5c-4316e87acdba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "789c3195-de2c-48d5-b46f-95fdecf00c00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98a1ad21-ff03-46c9-96da-d0a2f4283335");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29e44a05-58c8-4b78-9ab0-e0aa2f885d61", "aee356e1-ca3d-444e-9789-f00f7a90aa42", "Admin", "ADMIN" },
                    { "2a1b3c41-c6d3-4fa6-aab1-4e24c5a960fa", "183bd0d9-6674-4e62-886c-4ab4b69ecd1d", "Editor", "EDITOR" },
                    { "b25f6a27-a803-4074-8844-c1064a1dd536", "a0a58219-e0a5-460f-89ff-360fcc2c3390", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Computer Science" },
                    { 2, "Network" },
                    { 3, "Database Manegament Systems" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29e44a05-58c8-4b78-9ab0-e0aa2f885d61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a1b3c41-c6d3-4fa6-aab1-4e24c5a960fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b25f6a27-a803-4074-8844-c1064a1dd536");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ec29942-210f-4e1f-8c5c-4316e87acdba", "0852c420-6727-44f5-b2b8-50bc71a33ebc", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "789c3195-de2c-48d5-b46f-95fdecf00c00", "d3b361b7-fb7a-4e96-8af2-48ecf433c2fe", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98a1ad21-ff03-46c9-96da-d0a2f4283335", "5ca8247d-5963-43d3-a5cd-a3417dc65b89", "User", "USER" });
        }
    }
}
