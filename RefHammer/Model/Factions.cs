namespace RefHammer.Model
{
    public class Factions
    {
        public int Id { get; set; }
        public string Abbreviation { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string IsSubfaction { get; set; }
        public string ParentId { get; set; }

    }
}
