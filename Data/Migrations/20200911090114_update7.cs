﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ECorpSales.Data.Migrations
{
    public partial class update7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CartTotal",
                table: "Carts",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartTotal",
                table: "Carts");
        }
    }
}
