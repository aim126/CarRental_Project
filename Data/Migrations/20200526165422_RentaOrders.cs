using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalProject.Data.Migrations
{
    public partial class RentaOrderscs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RentalOrder",
                columns: table => new
                {
                    CarType = table.Column<string>(nullable: false),
                    PickUpDate = table.Column<string>(nullable: true),
                    ReturnDate = table.Column<string>(nullable: true),
                    Odometer = table.Column<int>(nullable: false),
                    FuelLevel = table.Column<string>(nullable: true),
                    ReturnLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalOrder", x => x.CarType);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    CarType = table.Column<string>(nullable: false),
                    CarPickupDate = table.Column<string>(nullable: true),
                    CarRequierdDays = table.Column<string>(nullable: true),
                    CarPIckupLocation = table.Column<string>(nullable: true),
                    CarReturnLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.CarType);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b10764a0-0bc2-4e7f-9161-6eb05288f161", "4975f65d-2341-4423-be43-959f4014de3b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentalOrder");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b10764a0-0bc2-4e7f-9161-6eb05288f161");
        }
    }
}
