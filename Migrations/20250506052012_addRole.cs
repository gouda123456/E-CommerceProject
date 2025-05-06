using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_CommerceProject.Migrations
{
    /// <inheritdoc />
    public partial class addRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8031380b-9ffe-4f72-a724-904630a3b971", "87fbdfe7-6f31-46bf-9763-ac322e094af9", "Admin", "admin" },
                    { "e9c016c9-a4ef-4e90-a5ad-8a725805e1dd", "6a3fffbc-53ce-4cd5-afa2-d65f2f0d630d", "User", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8031380b-9ffe-4f72-a724-904630a3b971");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9c016c9-a4ef-4e90-a5ad-8a725805e1dd");
        }
    }
}
