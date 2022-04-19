namespace Open5e_Data.Interfaces
{
    /* TODO
     * Return data models instead of void
     */

    public interface IOpen5eServer
    {
        public void GetSpells();
        public void GetMonsters();
        public void GetSections();
        public void GetConditions();
        public void GetRaces();
        public void GetClasses();
        public void GetMagicItems();
        public void GetWeapons();
    }
}
