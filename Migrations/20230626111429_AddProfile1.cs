using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Slaughter_House.Migrations
{
    /// <inheritdoc />
    public partial class AddProfile1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddProfiles_Registers_Username",
                table: "AddProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddProfiles",
                table: "AddProfiles");

            migrationBuilder.RenameTable(
                name: "AddProfiles",
                newName: "AddProfile");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddProfile",
                table: "AddProfile",
                column: "Username");

            migrationBuilder.AddForeignKey(
                name: "FK_AddProfile_Registers_Username",
                table: "AddProfile",
                column: "Username",
                principalTable: "Registers",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddProfile_Registers_Username",
                table: "AddProfile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddProfile",
                table: "AddProfile");

            migrationBuilder.RenameTable(
                name: "AddProfile",
                newName: "AddProfiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddProfiles",
                table: "AddProfiles",
                column: "Username");

            migrationBuilder.AddForeignKey(
                name: "FK_AddProfiles_Registers_Username",
                table: "AddProfiles",
                column: "Username",
                principalTable: "Registers",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
