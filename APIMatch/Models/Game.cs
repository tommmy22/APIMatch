using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfSits { get; set; }
        public string Address { get; set; }
        public int? HomeTeamId { get; set; }
        [ForeignKey("HomeTeamId")]
        public Team HomeTeam { get; set; }
        public int? ExtTeamId { get; set; }
        [ForeignKey("ExtTeamId")]
        public Team ExtTeam { get; set; }

        public int? ChampionshipId { get; set; }
        [ForeignKey("ChampionshipId")]
        public Championship Championship { get; set; }
        public string Commentaire { get; set; }

    }
}
