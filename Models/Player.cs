namespace SoccerTeamTracker.Models
{
    public class Player
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
