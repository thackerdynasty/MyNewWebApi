using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyNewWebApi.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Strength",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "Weakness",
                table: "Pokemons",
                newName: "Type2");

            migrationBuilder.AddColumn<int>(
                name: "Attack",
                table: "Pokemons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Defense",
                table: "Pokemons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Hp",
                table: "Pokemons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Legendary",
                table: "Pokemons",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Speed",
                table: "Pokemons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpeedAttack",
                table: "Pokemons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpeedDefense",
                table: "Pokemons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attack",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Defense",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Legendary",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "SpeedAttack",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "SpeedDefense",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "Type2",
                table: "Pokemons",
                newName: "Weakness");

            migrationBuilder.AddColumn<string>(
                name: "Strength",
                table: "Pokemons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
