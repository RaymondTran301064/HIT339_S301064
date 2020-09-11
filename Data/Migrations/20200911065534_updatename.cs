using Microsoft.EntityFrameworkCore.Migrations;

namespace ECorpSales.Data.Migrations
{
    public partial class updatename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "NameId",
                table: "Sales",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NameId",
                table: "Carts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_NameId",
                table: "Sales",
                column: "NameId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_NameId",
                table: "Carts",
                column: "NameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Items_NameId",
                table: "Carts",
                column: "NameId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Items_NameId",
                table: "Sales",
                column: "NameId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Items_NameId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Items_NameId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_NameId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Carts_NameId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "NameId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "NameId",
                table: "Carts");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
