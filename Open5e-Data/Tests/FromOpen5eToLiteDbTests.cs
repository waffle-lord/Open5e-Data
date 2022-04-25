using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open5e_Data.Controllers;
using Open5e_Data.Interfaces;
using Open5e_Data.Servers;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class FromOpen5eToLiteDbTests
    {
        [TestMethod]
        public async Task Spells()
        {
            var open5eApi = new Open5eAPIController();

            var liteDb = new LiteDbController();

            var spells = await open5eApi.GetSpellsAsync();
        }
    }
}