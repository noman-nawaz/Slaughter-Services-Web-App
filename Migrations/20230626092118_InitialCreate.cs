using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Slaughter_House.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddProfile",
                columns: table => new
                {
                    ProfileID = table.Column<int>(type: "int", nullable: false),
                    Goat = table.Column<bool>(type: "bit", nullable: false),
                    Sheep = table.Column<bool>(type: "bit", nullable: false),
                    Camel = table.Column<bool>(type: "bit", nullable: false),
                    Day1Slot1 = table.Column<bool>(type: "bit", nullable: false),
                    Day1Slot2 = table.Column<bool>(type: "bit", nullable: false),
                    Day1Slot3 = table.Column<bool>(type: "bit", nullable: false),
                    Day2Slot1 = table.Column<bool>(type: "bit", nullable: false),
                    Day2Slot2 = table.Column<bool>(type: "bit", nullable: false),
                    Day2Slot3 = table.Column<bool>(type: "bit", nullable: false),
                    Day3Slot1 = table.Column<bool>(type: "bit", nullable: false),
                    Day3Slot2 = table.Column<bool>(type: "bit", nullable: false),
                    Day3Slot3 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddProfile", x => x.ProfileID);
                    table.ForeignKey(
                        name: "FK_AddProfile_Registers_ProfileID",
                        column: x => x.ProfileID,
                        principalTable: "Registers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddProfile");
        }
    }
}
