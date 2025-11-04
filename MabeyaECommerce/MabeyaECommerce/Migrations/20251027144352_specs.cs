using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MabeyaECommerce.Migrations
{
    /// <inheritdoc />
    public partial class specs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Specs_specId",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Specs_Category_categoryId",
                table: "Specs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specs",
                table: "Specs");

            migrationBuilder.RenameTable(
                name: "Specs",
                newName: "Spec");

            migrationBuilder.RenameIndex(
                name: "IX_Specs_categoryId",
                table: "Spec",
                newName: "IX_Spec_categoryId");

            migrationBuilder.AlterColumn<Guid>(
                name: "categoryId",
                table: "Spec",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Spec",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Spec",
                table: "Spec",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Spec_Name",
                table: "Spec",
                column: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Spec_specId",
                table: "ProductDetails",
                column: "specId",
                principalTable: "Spec",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spec_Category_categoryId",
                table: "Spec",
                column: "categoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Spec_specId",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Spec_Category_categoryId",
                table: "Spec");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Spec",
                table: "Spec");

            migrationBuilder.DropIndex(
                name: "IX_Spec_Name",
                table: "Spec");

            migrationBuilder.RenameTable(
                name: "Spec",
                newName: "Specs");

            migrationBuilder.RenameIndex(
                name: "IX_Spec_categoryId",
                table: "Specs",
                newName: "IX_Specs_categoryId");

            migrationBuilder.AlterColumn<Guid>(
                name: "categoryId",
                table: "Specs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Specs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specs",
                table: "Specs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Specs_specId",
                table: "ProductDetails",
                column: "specId",
                principalTable: "Specs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specs_Category_categoryId",
                table: "Specs",
                column: "categoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }
    }
}
