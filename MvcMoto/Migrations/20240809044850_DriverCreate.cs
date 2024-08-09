using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMoto.Migrations
{
    /// <inheritdoc />
    public partial class DriverCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DriverNumber",
                table: "Moto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverNumber",
                table: "Moto");
        }
    }
}
