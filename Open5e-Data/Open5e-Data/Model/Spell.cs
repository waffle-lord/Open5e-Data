using Newtonsoft.Json;

namespace Open5e_Data.Model
{
    public class Spell
    {
        public string Slug { get; set; }
        public string Name { get; set; }
        [JsonProperty("desc")]
        public string Description { get; set; }
        [JsonProperty("higher_level")]
        public string HigherLevel { get; set; }
        public string Page { get; set; }
        public string Range { get; set; }
        public string Components { get; set; }
        public string Material { get; set; }
        public string Ritual { get; set; }
        public string Duration { get; set; }
        public string Concentration { get; set; }
        [JsonProperty("casting_time")]
        public string CastingTime { get; set; }
        public string Level { get; set; }
        [JsonProperty("level_int")]
        public int LevelInt { get; set; }
        public string School { get; set; }
        [JsonProperty("dnd_class")]
        public string DndClass { get; set; }
        public string Archetype { get; set; }
        public string Circles { get; set; }
    }
}
