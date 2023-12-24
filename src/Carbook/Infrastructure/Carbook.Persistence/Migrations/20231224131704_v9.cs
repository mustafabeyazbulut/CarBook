﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carbook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PickUpLocationId",
                table: "RentACars");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PickUpLocationId",
                table: "RentACars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
