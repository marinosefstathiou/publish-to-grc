using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KubeTestAPI.Migrations
{
    /// <inheritdoc />
    public partial class test02142023949 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Temperatures",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Temperatures");
        }
    }
}
