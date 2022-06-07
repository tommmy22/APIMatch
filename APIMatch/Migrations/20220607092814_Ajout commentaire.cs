using Microsoft.EntityFrameworkCore.Migrations;

namespace APIMatch.Migrations
{
    public partial class Ajoutcommentaire : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Commentaire",
                table: "Game",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Commentaire",
                table: "Game");
        }
    }
}
