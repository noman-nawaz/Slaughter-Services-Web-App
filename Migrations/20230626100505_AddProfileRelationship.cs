using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Slaughter_House.Migrations
{
    /// <inheritdoc />
    public partial class AddProfileRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddProfile_Registers_ProfileID",
                table: "AddProfile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Registers",
                table: "Registers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddProfile",
                table: "AddProfile");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Registers");

            migrationBuilder.DropColumn(
                name: "ProfileID",
                table: "AddProfile");

            migrationBuilder.RenameTable(
                name: "AddProfile",
                newName: "AddProfiles");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Registers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "AddProfiles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registers",
                table: "Registers",
                column: "Username");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddProfiles_Registers_Username",
                table: "AddProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Registers",
                table: "Registers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddProfiles",
                table: "AddProfiles");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "AddProfiles");

            migrationBuilder.RenameTable(
                name: "AddProfiles",
                newName: "AddProfile");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Registers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Registers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ProfileID",
                table: "AddProfile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registers",
                table: "Registers",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddProfile",
                table: "AddProfile",
                column: "ProfileID");

            migrationBuilder.AddForeignKey(
                name: "FK_AddProfile_Registers_ProfileID",
                table: "AddProfile",
                column: "ProfileID",
                principalTable: "Registers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
