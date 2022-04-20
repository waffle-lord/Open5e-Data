using Open5e_Data.Model;

namespace Open5e_Data.Interfaces
{
    public interface IOpen5eServer
    {
        public Task<Open5eResponse<Spell>> GetSpells(int limit = 9999);
        public void GetMonsters();
        public void GetSections();
        public void GetConditions();
        public void GetRaces();
        public void GetClasses();
        public void GetMagicItems();
        public void GetWeapons();
    }
}
