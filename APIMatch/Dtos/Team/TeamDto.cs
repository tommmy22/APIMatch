using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Dtos.Team
{
    public class TeamDto
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public int ChampionshipId { get; set; }
        public string ChampionshipName { get; set; }
        public string ImageUrl { get; set; }
        public string ImageStade { get; set; }
    }
}
