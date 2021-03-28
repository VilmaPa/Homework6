using Microsoft.EntityFrameworkCore.Migrations;

namespace Homework6.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fruits_Shops_ShopId",
                table: "Fruits");

            migrationBuilder.DropIndex(
                name: "IX_Fruits_ShopId",
                table: "Fruits");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Fruits_ShopId",
                table: "Fruits",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fruits_Shops_ShopId",
                table: "Fruits",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
