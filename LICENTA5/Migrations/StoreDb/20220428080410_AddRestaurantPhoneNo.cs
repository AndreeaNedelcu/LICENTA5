using Microsoft.EntityFrameworkCore.Migrations;

namespace LICENTA5.Migrations.StoreDb
{
    public partial class AddRestaurantPhoneNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "Restaurants",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "Restaurants");
        }
    }
}
