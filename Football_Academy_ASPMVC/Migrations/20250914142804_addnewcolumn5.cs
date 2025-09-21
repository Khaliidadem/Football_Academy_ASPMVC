using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Football_Academy_ASPMVC.Migrations
{
    /// <inheritdoc />
    public partial class addnewcolumn5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "matches");

            migrationBuilder.RenameColumn(
                name: "TeamTwo",
                table: "matches",
                newName: "HomeTeam");

            migrationBuilder.RenameColumn(
                name: "TeamOne",
                table: "matches",
                newName: "AwayTeam");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HomeTeam",
                table: "matches",
                newName: "TeamTwo");

            migrationBuilder.RenameColumn(
                name: "AwayTeam",
                table: "matches",
                newName: "TeamOne");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "matches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
