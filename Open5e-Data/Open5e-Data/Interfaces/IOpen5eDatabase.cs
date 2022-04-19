using Open5e_Data.Interfaces.Database;

namespace Open5e_Data.Interfaces
{
    public interface IOpen5eDatabase
    {
        public ISpellsAccessor Spells { get; }
    }
}
