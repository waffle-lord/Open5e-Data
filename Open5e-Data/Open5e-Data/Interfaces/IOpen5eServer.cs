using Open5e_Data.Model;

namespace Open5e_Data.Interfaces
{
    public interface IOpen5eServer
    {
        public Task<Open5eResponse<Spell>> GetSpellsAsync(int limit = 9999);
        public void GetMonstersAsync();
        public void GetSectionsAsync();
        public void GetConditionsAsync();
        public void GetRacesAsync();
        public void GetClassesAsync();
        public void GetMagicItemsAsync();
        public void GetWeaponsAsync();
    }
}
