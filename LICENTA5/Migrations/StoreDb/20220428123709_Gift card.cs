using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LICENTA5.Migrations.StoreDb
{
    public partial class Giftcard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GiftCards",
                columns: table => new
                {
                    GiftCardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardValue = table.Column<int>(nullable: false),
                    ReceiverEmail = table.Column<string>(nullable: false),
                    SenderFullName = table.Column<string>(nullable: false),
                    SenderCardNo = table.Column<string>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    SenderCVV = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftCards", x => x.GiftCardID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiftCards");
        }
    }
}
