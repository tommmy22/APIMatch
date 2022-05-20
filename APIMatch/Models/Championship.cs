using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Models
{
    public class Championship
    {
        public int ChampionshipId { get; set; }
        public string Name { get; set; }
        public ICollection<Team> Teams { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
