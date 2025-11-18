using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MabeyaECommerce.Migrations
{
    /// <inheritdoc />
    public partial class adres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Cities_cityId",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "cityId",
                table: "Address",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_cityId",
                table: "Address",
                newName: "IX_Address_CityId");

            migrationBuilder.AddColumn<string>(
                name: "TaxNumber",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxOffice",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Cities_CityId",
                table: "Address",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Cities_CityId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "TaxNumber",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "TaxOffice",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Address",
                newName: "cityId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_CityId",
                table: "Address",
                newName: "IX_Address_cityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Cities_cityId",
                table: "Address",
                column: "cityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
