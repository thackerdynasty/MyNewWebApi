using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyNewWebApi.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stage",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "imageUrl",
                table: "Pokemons");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stage",
                table: "Pokemons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "imageUrl",
                table: "Pokemons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
