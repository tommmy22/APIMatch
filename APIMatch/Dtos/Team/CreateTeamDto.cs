namespace APIMatch.Dtos.Team
{
    public class CreateTeamDto
    {
        public string Name { get; set; }
        public int ChampionshipId { get; set; }
        public string ImageUrl { get; set; }
        public string ImageStade { get; set; }
    }
}
