using Open5e_Data.Interfaces;
using Open5e_Data.Interfaces.Database;
using Open5e_Data.Model.Database;

namespace Open5e_Data.Servers
{
    public class LiteDbServer : IOpen5eDatabase
    {
        public ISpellsAccessor Spells { get; private set; } = new LiteDbSpellsAccessor();
    }
}
