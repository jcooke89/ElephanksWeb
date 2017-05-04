using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElephanksWeb.Migrations
{
    public partial class removeIdsFromParent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trunks_PostalAddress_AddressId",
                table: "Trunks");

            migrationBuilder.DropForeignKey(
                name: "FK_Trunks_Product_ProductId",
                table: "Trunks");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Trunks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Trunks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Trunks_PostalAddress_AddressId",
                table: "Trunks",
                column: "AddressId",
                principalTable: "PostalAddress",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trunks_Product_ProductId",
                table: "Trunks",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trunks_PostalAddress_AddressId",
                table: "Trunks");

            migrationBuilder.DropForeignKey(
                name: "FK_Trunks_Product_ProductId",
                table: "Trunks");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Trunks",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Trunks",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Trunks_PostalAddress_AddressId",
                table: "Trunks",
                column: "AddressId",
                principalTable: "PostalAddress",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trunks_Product_ProductId",
                table: "Trunks",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
