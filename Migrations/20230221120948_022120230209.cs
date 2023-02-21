﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KubeTestAPI.Migrations
{
    /// <inheritdoc />
    public partial class _022120230209 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Town",
                table: "Temperatures",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Town",
                table: "Temperatures");
        }
    }
}
