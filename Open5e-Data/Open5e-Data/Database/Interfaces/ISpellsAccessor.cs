using Open5e_Data.Model;

namespace Open5e_Data.Database.Interfaces
{
    public interface ISpellsAccessor
    {
        public List<Spell> GetAllSpells();

        public Spell GetSpellByName(string name);

        public bool AddSpell(Spell spell);

        public bool RemoveSpell(Spell spell);
    }
}
