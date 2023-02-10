using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KubeTestAPI.Migrations
{
    /// <inheritdoc />
    public partial class testworkingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Temperature",
                table: "Temperatures");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Temperature",
                table: "Temperatures",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
