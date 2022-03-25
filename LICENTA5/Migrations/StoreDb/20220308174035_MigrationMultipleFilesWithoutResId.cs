using Microsoft.EntityFrameworkCore.Migrations;

namespace LICENTA5.Migrations.StoreDb
{
    public partial class MigrationMultipleFilesWithoutResId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "RestaurantGallery");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "RestaurantGallery",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
