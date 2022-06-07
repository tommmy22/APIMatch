using APIMatch.Dtos.Team;
using System;

namespace APIMatch.Dtos.Game
{
    public class GameDto
    {
        public int GameId { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfSits { get; set; }
        public string Address { get; set; }
        public int HomeTeamId { get; set; }
        public TeamDto HomeTeam { get; set; }
        public int ExtTeamId { get; set; }
        public TeamDto ExtTeam { get; set; }
        public int Commentaire { get; set; }
    }
}
