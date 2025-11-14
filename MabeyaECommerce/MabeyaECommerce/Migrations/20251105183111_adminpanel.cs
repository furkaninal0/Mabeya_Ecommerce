using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MabeyaECommerce.Migrations
{
    /// <inheritdoc />
    public partial class adminpanel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ShippingAddressId",
                table: "ShoppedOrders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "ShippingNumber",
                table: "ShoppedOrders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ShoppedOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShippingAddressId",
                table: "ShoppedOrders");

            migrationBuilder.DropColumn(
                name: "ShippingNumber",
                table: "ShoppedOrders");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ShoppedOrders");
        }
    }
}
