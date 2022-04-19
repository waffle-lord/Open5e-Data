using Open5e_Data.Interfaces;

namespace Open5e_Data.Controllers
{
    public class Open5eAPIController
    {
        private IOpen5eServer _server { get; set; }

        public Open5eAPIController(IOpen5eServer server)
        {
            _server = server;
        }
    }
}
