using Open5e_Data.Database.Context;
using Open5e_Data.Database.Interfaces;
using Open5e_Data.Model;

namespace Open5e_Data.Database.Accessors
{
    internal class LiteDbSpellsAccessor : ISpellsAccessor
    {
        public bool AddSpell(Spell spell)
        {
            throw new NotImplementedException();
        }

        public List<Spell> GetAllSpells()
        {
            using var dbContext = new LiteDbContext();

            return dbContext.Database.GetCollection<Spell>().FindAll().ToList();
        }

        public Spell GetSpellByName(string name)
        {
            using var dbContext = new LiteDbContext();

            var spells = dbContext.Database.GetCollection<Spell>();

            spells.EnsureIndex(x => x.Name);

            return spells.FindOne(x => x.Name == name);
        }

        public bool RemoveSpell(Spell spell)
        {
            using var dbContext = new LiteDbContext();

            var spells = dbContext.Database.GetCollection<Spell>();

            return false;
        }
    }
}
