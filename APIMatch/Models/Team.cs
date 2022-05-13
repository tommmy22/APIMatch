using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public int ChampionshipId { get; set; }
        public Championship Championship { get; set; }

        public string ImageUrl { get; set; }
        public string ImageStade { get; set; }
    }
}
