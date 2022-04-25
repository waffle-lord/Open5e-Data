using Open5e_Data.Database.Interfaces;

namespace Open5e_Data.Interfaces
{
    public interface IOpen5eDatabase
    {
        public ISpellsAccessor Spells { get; }
    }
}
