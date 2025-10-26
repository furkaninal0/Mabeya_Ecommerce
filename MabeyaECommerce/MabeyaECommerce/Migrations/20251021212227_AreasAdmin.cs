using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MabeyaECommerce.Migrations
{
    /// <inheritdoc />
    public partial class AreasAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_specId",
                table: "ProductDetails",
                column: "specId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Products_productId",
                table: "ProductDetails",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Specs_specId",
                table: "ProductDetails",
                column: "specId",
                principalTable: "Specs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Products_productId",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Specs_specId",
                table: "ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_specId",
                table: "ProductDetails");
        }
    }
}
