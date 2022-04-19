using Microsoft.EntityFrameworkCore.Migrations;

namespace LICENTA5.Migrations.StoreDb
{
    public partial class ConfirmedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Confirmed",
                table: "Restaurants",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Confirmed",
                table: "Restaurants");
        }
    }
}
