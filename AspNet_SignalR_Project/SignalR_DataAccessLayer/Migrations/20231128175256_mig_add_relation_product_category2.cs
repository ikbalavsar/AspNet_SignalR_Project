using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_relation_product_category2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Catgeories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catgeories",
                table: "Catgeories");

            migrationBuilder.RenameTable(
                name: "Catgeories",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Catgeories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catgeories",
                table: "Catgeories",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Catgeories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Catgeories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
