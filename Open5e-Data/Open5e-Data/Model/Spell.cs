using LiteDB;
using Newtonsoft.Json;

namespace Open5e_Data.Model
{
    public class Spell
    {
        public ObjectId Id { get; set; }
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

        public Spell()
        {
            Id = ObjectId.NewObjectId();
        }

        [BsonCtor]
        public Spell(ObjectId _id, string name, string description, string higherLevel, 
                     string page, string range, string components, string material, string ritual,
                     string duration, string concentration, string castingTime, string level, int levelInt,
                     string school, string dndClass, string archeType, string circles)
        {
            Id = _id;
            Name = name;
            Description = description;
            HigherLevel = higherLevel;
            Page = page;
            Range = range;
            Components = components;
            Material = material;
            Ritual = ritual;
            Duration = duration;
            Concentration = concentration;
            CastingTime = castingTime;
            Level = level;
            LevelInt = levelInt;
            School = school;
            DndClass = dndClass;
            Archetype = archeType;
            Circles = circles;
        }
    }
}
