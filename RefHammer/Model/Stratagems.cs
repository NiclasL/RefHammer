using Microsoft.AspNetCore.Mvc;
using RefHammer.Model;

namespace RefHammer.Model
{
    public class Stratagems 
    {
        public int Id { get; set; }
        public string faction_id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string cp_cost { get; set; }
        public string legend { get; set; }
        public string source_id { get; set; }
        public string subfaction_id { get; set; }
        public string description { get; set; }



    }
}