using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftUniSpaceConsoleWebApp.Migrations
{
    /// <inheritdoc />
    public partial class ShipFk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FkCrewId",
                table: "Ship",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ship_FkCrewId",
                table: "Ship",
                column: "FkCrewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ship_Crewmen_FkCrewId",
                table: "Ship",
                column: "FkCrewId",
                principalTable: "Crewmen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ship_Crewmen_FkCrewId",
                table: "Ship");

            migrationBuilder.DropIndex(
                name: "IX_Ship_FkCrewId",
                table: "Ship");

            migrationBuilder.DropColumn(
                name: "FkCrewId",
                table: "Ship");
        }
    }
}
