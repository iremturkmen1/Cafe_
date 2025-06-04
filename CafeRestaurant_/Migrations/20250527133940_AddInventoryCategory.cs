using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeRestaurant_.Migrations
{
    public partial class AddInventoryCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InventoryCategoryId",
                table: "Envanters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InventoryCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Envanters_InventoryCategoryId",
                table: "Envanters",
                column: "InventoryCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Envanters_InventoryCategories_InventoryCategoryId",
                table: "Envanters",
                column: "InventoryCategoryId",
                principalTable: "InventoryCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Envanters_InventoryCategories_InventoryCategoryId",
                table: "Envanters");

            migrationBuilder.DropTable(
                name: "InventoryCategories");

            migrationBuilder.DropIndex(
                name: "IX_Envanters_InventoryCategoryId",
                table: "Envanters");

            migrationBuilder.DropColumn(
                name: "InventoryCategoryId",
                table: "Envanters");
        }
    }
}
