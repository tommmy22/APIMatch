using Microsoft.EntityFrameworkCore.Migrations;

namespace APIMatch.Migrations
{
    public partial class CreationTableEtat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EtatId",
                table: "Game",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Etat",
                columns: table => new
                {
                    EtatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etat", x => x.EtatId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Game_EtatId",
                table: "Game",
                column: "EtatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Etat_EtatId",
                table: "Game",
                column: "EtatId",
                principalTable: "Etat",
                principalColumn: "EtatId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Etat_EtatId",
                table: "Game");

            migrationBuilder.DropTable(
                name: "Etat");

            migrationBuilder.DropIndex(
                name: "IX_Game_EtatId",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "EtatId",
                table: "Game");
        }
    }
}
