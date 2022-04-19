using Microsoft.EntityFrameworkCore.Migrations;

namespace LICENTA5.Migrations.StoreDb
{
    public partial class AddedByField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddedBy",
                table: "Restaurants",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "Restaurants");
        }
    }
}
