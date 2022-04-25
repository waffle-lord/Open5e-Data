using Open5e_Data.Interfaces;
using Open5e_Data.Servers;

namespace Open5e_Data.Controllers
{
    public class LiteDbController
    {
        private IOpen5eDatabase _database { get; set; }

        public LiteDbController(IOpen5eDatabase database = null)
        {
            _database = database ?? new LiteDbServer();
        }


    }
}
