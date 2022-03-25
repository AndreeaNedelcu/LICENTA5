using Microsoft.EntityFrameworkCore.Migrations;

namespace LICENTA5.Migrations.StoreDb
{
    public partial class ModifiedTableGallery3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantGallery_Restaurants_RestaurantID",
                table: "RestaurantGallery");

            migrationBuilder.DropIndex(
                name: "IX_RestaurantGallery_RestaurantID",
                table: "RestaurantGallery");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "RestaurantGallery");

            migrationBuilder.RenameColumn(
                name: "RestaurantID",
                table: "RestaurantGallery",
                newName: "RestaurantId");

            migrationBuilder.AlterColumn<int>(
                name: "RestaurantId",
                table: "RestaurantGallery",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "restaurantsRestaurantID",
                table: "RestaurantGallery",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantGallery_restaurantsRestaurantID",
                table: "RestaurantGallery",
                column: "restaurantsRestaurantID");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantGallery_Restaurants_restaurantsRestaurantID",
                table: "RestaurantGallery",
                column: "restaurantsRestaurantID",
                principalTable: "Restaurants",
                principalColumn: "RestaurantID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantGallery_Restaurants_restaurantsRestaurantID",
                table: "RestaurantGallery");

            migrationBuilder.DropIndex(
                name: "IX_RestaurantGallery_restaurantsRestaurantID",
                table: "RestaurantGallery");

            migrationBuilder.DropColumn(
                name: "restaurantsRestaurantID",
                table: "RestaurantGallery");

            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                table: "RestaurantGallery",
                newName: "RestaurantID");

            migrationBuilder.AlterColumn<long>(
                name: "RestaurantID",
                table: "RestaurantGallery",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "RestaurantGallery",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantGallery_RestaurantID",
                table: "RestaurantGallery",
                column: "RestaurantID");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantGallery_Restaurants_RestaurantID",
                table: "RestaurantGallery",
                column: "RestaurantID",
                principalTable: "Restaurants",
                principalColumn: "RestaurantID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
