using Open5e_Data.Interfaces;
using Open5e_Data.Model;
using Open5e_Data.Servers;

namespace Open5e_Data.Controllers
{
    public class Open5eAPIController
    {
        private IOpen5eServer _server { get; set; }

        public Open5eAPIController(IOpen5eServer server = null)
        {
            _server = server ?? new Open5eServer();
        }

        public async Task<List<Spell>> GetSpellsAsync()
        {
            var response = await _server.GetSpellsAsync();

            if (response == null) return new List<Spell>();

            return response.Results ?? new List<Spell>();
        }
    }
}
