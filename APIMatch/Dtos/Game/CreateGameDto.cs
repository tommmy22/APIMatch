using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Dtos.Game
{
    public class CreateGameDto
    {
        public DateTime Date { get; set; }
        public int NumberOfSits { get; set; }
        public string Address { get; set; }
        public int ExtTeamId { get; set; }
        public int HomeTeamId { get; set; }
        public int ChampionshipId { get; set; }
        public int Commentaire { get; set; }
    }
}
