using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Football_Academy_ASPMVC.Migrations
{
    /// <inheritdoc />
    public partial class TeamIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "players");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "teams",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Team",
                table: "players",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "coaches",
                newName: "FullName");

            migrationBuilder.AddColumn<int>(
                name: "CoachId",
                table: "teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CoachId",
                table: "players",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "players",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_teams_CoachId",
                table: "teams",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_players_CoachId",
                table: "players",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_players_TeamId",
                table: "players",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_players_coaches_CoachId",
                table: "players",
                column: "CoachId",
                principalTable: "coaches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_players_teams_TeamId",
                table: "players",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_teams_coaches_CoachId",
                table: "teams",
                column: "CoachId",
                principalTable: "coaches",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_players_coaches_CoachId",
                table: "players");

            migrationBuilder.DropForeignKey(
                name: "FK_players_teams_TeamId",
                table: "players");

            migrationBuilder.DropForeignKey(
                name: "FK_teams_coaches_CoachId",
                table: "teams");

            migrationBuilder.DropIndex(
                name: "IX_teams_CoachId",
                table: "teams");

            migrationBuilder.DropIndex(
                name: "IX_players_CoachId",
                table: "players");

            migrationBuilder.DropIndex(
                name: "IX_players_TeamId",
                table: "players");

            migrationBuilder.DropColumn(
                name: "CoachId",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "CoachId",
                table: "players");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "players");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "teams",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "players",
                newName: "Team");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "coaches",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
