using Microsoft.EntityFrameworkCore.Migrations;

namespace APIMatch.Migrations
{
    public partial class addforeignchampioshipid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChampionshipId",
                table: "Game",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Game_ChampionshipId",
                table: "Game",
                column: "ChampionshipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Championship_ChampionshipId",
                table: "Game",
                column: "ChampionshipId",
                principalTable: "Championship",
                principalColumn: "ChampionshipId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Championship_ChampionshipId",
                table: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Game_ChampionshipId",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "ChampionshipId",
                table: "Game");
        }
    }
}
