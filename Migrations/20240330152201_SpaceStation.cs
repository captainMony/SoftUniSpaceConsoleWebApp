using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftUniSpaceConsoleWebApp.Migrations
{
    /// <inheritdoc />
    public partial class SpaceStation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SpaceStationName",
                table: "SpaceStation",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SpaceStationId",
                table: "SpaceStation",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SpaceStation",
                newName: "SpaceStationName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SpaceStation",
                newName: "SpaceStationId");
        }
    }
}
