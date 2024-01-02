using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Slaughter_House.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedButcher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Camel",
                table: "AddProfiles");

            migrationBuilder.DropColumn(
                name: "Day1Slot1",
                table: "AddProfiles");

            migrationBuilder.DropColumn(
                name: "Day1Slot2",
                table: "AddProfiles");

            migrationBuilder.DropColumn(
                name: "Day1Slot3",
                table: "AddProfiles");

            migrationBuilder.DropColumn(
                name: "Day2Slot1",
                table: "AddProfiles");

            migrationBuilder.DropColumn(
                name: "Day2Slot2",
                table: "AddProfiles");

            migrationBuilder.DropColumn(
                name: "Day2Slot3",
                table: "AddProfiles");

            migrationBuilder.DropColumn(
                name: "Day3Slot1",
                table: "AddProfiles");

            migrationBuilder.DropColumn(
                name: "Day3Slot2",
                table: "AddProfiles");

            migrationBuilder.DropColumn(
                name: "Day3Slot3",
                table: "AddProfiles");

            migrationBuilder.DropColumn(
                name: "Goat",
                table: "AddProfiles");

            migrationBuilder.DropColumn(
                name: "Sheep",
                table: "AddProfiles");

            migrationBuilder.AddColumn<string>(
                name: "Animal",
                table: "AddProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "AddProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "AddProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Animal",
                table: "AddProfiles");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "AddProfiles");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AddProfiles");

            migrationBuilder.AddColumn<bool>(
                name: "Camel",
                table: "AddProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Day1Slot1",
                table: "AddProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Day1Slot2",
                table: "AddProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Day1Slot3",
                table: "AddProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Day2Slot1",
                table: "AddProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Day2Slot2",
                table: "AddProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Day2Slot3",
                table: "AddProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Day3Slot1",
                table: "AddProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Day3Slot2",
                table: "AddProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Day3Slot3",
                table: "AddProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Goat",
                table: "AddProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sheep",
                table: "AddProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
