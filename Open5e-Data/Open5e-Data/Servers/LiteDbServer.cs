using Open5e_Data.Database.Accessors;
using Open5e_Data.Database.Interfaces;
using Open5e_Data.Interfaces;

namespace Open5e_Data.Servers
{
    internal class LiteDbServer : IOpen5eDatabase
    {
        public ISpellsAccessor Spells { get; private set; } = new LiteDbSpellsAccessor();
    }
}
