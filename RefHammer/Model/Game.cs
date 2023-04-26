using RefHammer.Enums;

namespace RefHammer.Model
{
    public class Game
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public GameType gameType { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }
}
