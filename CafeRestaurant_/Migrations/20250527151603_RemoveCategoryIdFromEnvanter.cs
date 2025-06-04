using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeRestaurant_.Migrations
{
    public partial class RemoveCategoryIdFromEnvanter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Envanters_Categories_CategoryId",
                table: "Envanters");

            migrationBuilder.DropForeignKey(
                name: "FK_Envanters_InventoryCategories_InventoryCategoryId",
                table: "Envanters");

            migrationBuilder.DropIndex(
                name: "IX_Envanters_CategoryId",
                table: "Envanters");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Envanters");

            migrationBuilder.AlterColumn<int>(
                name: "InventoryCategoryId",
                table: "Envanters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Envanters_InventoryCategories_InventoryCategoryId",
                table: "Envanters",
                column: "InventoryCategoryId",
                principalTable: "InventoryCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Envanters_InventoryCategories_InventoryCategoryId",
                table: "Envanters");

            migrationBuilder.AlterColumn<int>(
                name: "InventoryCategoryId",
                table: "Envanters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Envanters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Envanters_CategoryId",
                table: "Envanters",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Envanters_Categories_CategoryId",
                table: "Envanters",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Envanters_InventoryCategories_InventoryCategoryId",
                table: "Envanters",
                column: "InventoryCategoryId",
                principalTable: "InventoryCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
