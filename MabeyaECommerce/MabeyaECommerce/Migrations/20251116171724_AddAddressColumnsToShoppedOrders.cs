using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MabeyaECommerce.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressColumnsToShoppedOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1) Eski gereksiz kolon kaldırılıyor
            migrationBuilder.DropColumn(
                name: "addressId",
                table: "ShoppedOrders");

            // 2) Eksik BillingAddressId ekleniyor
            migrationBuilder.AddColumn<Guid>(
                name: "BillingAddressId",
                table: "ShoppedOrders",
                type: "uniqueidentifier",
                nullable: true);

            // 3) Foreign key ekleniyor (BillingAddress)
            migrationBuilder.CreateIndex(
                name: "IX_ShoppedOrders_BillingAddressId",
                table: "ShoppedOrders",
                column: "BillingAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppedOrders_Address_BillingAddressId",
                table: "ShoppedOrders",
                column: "BillingAddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // DOWN işlemi (geri dönüş için)
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppedOrders_Address_BillingAddressId",
                table: "ShoppedOrders");

            migrationBuilder.DropIndex(
                name: "IX_ShoppedOrders_BillingAddressId",
                table: "ShoppedOrders");

            migrationBuilder.DropColumn(
                name: "BillingAddressId",
                table: "ShoppedOrders");

            // Eski kolon geri eklenebilir ama gerek yok
            migrationBuilder.AddColumn<Guid>(
                name: "addressId",
                table: "ShoppedOrders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: Guid.Empty);
        }
    }
}
