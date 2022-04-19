using Open5e_Data.Interfaces;

namespace Open5e_Data.Controllers
{
    public class LiteDbController
    {
        private IOpen5eDatabase _database { get; set; }

        public LiteDbController(IOpen5eDatabase database)
        {
            _database = database;
        }
    }
}
