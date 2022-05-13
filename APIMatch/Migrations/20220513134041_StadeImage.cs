using Microsoft.EntityFrameworkCore.Migrations;

namespace APIMatch.Migrations
{
    public partial class StadeImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageStade",
                table: "Team",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageStade",
                table: "Team");
        }
    }
}
