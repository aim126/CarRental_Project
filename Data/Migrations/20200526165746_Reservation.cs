using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalProject.Data.Migrations
{
    public partial class Reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b10764a0-0bc2-4e7f-9161-6eb05288f161");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7dc40dfc-8b57-49fc-a2b0-29bc4ea2d3dc", "6582fbd5-83b2-40cf-a45e-57e4d43ef687", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dc40dfc-8b57-49fc-a2b0-29bc4ea2d3dc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b10764a0-0bc2-4e7f-9161-6eb05288f161", "4975f65d-2341-4423-be43-959f4014de3b", "Admin", "ADMIN" });
        }
    }
}
