using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Football_Academy_ASPMVC.Migrations
{
    /// <inheritdoc />
    public partial class addnewcolumn3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalStaff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalStaff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerMedicalStaff",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId1 = table.Column<int>(type: "int", nullable: false),
                    MedicalStaffId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerMedicalStaff", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_PlayerMedicalStaff_MedicalStaff_MedicalStaffId",
                        column: x => x.MedicalStaffId,
                        principalTable: "MedicalStaff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerMedicalStaff_players_PlayerId1",
                        column: x => x.PlayerId1,
                        principalTable: "players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMedicalStaff_MedicalStaffId",
                table: "PlayerMedicalStaff",
                column: "MedicalStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMedicalStaff_PlayerId1",
                table: "PlayerMedicalStaff",
                column: "PlayerId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerMedicalStaff");

            migrationBuilder.DropTable(
                name: "MedicalStaff");
        }
    }
}
