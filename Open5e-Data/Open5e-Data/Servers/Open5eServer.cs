using Newtonsoft.Json;
using Open5e_Data.Interfaces;
using Open5e_Data.Model;

namespace Open5e_Data.Servers
{
    public class Open5eServer : IOpen5eServer
    {
        private static HttpClient _client = new HttpClient();

        public Open5eServer(string open5eApiRoot = "https://api.open5e.com")
        {
            _client.BaseAddress = new Uri(open5eApiRoot);
        }

        private async Task<Open5eResponse<T>> ResponseHandler<T>(string route) where T : class
        {
            var result = await _client.GetAsync(route);

            if (!result.IsSuccessStatusCode) return null;

            string responseString = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Open5eResponse<T>>(responseString);
        }

        public void GetClasses()
        {
            throw new NotImplementedException();
        }

        public void GetConditions()
        {
            throw new NotImplementedException();
        }

        public void GetMagicItems()
        {
            throw new NotImplementedException();
        }

        public void GetMonsters()
        {
            throw new NotImplementedException();
        }

        public void GetRaces()
        {
            throw new NotImplementedException();
        }

        public void GetSections()
        {
            throw new NotImplementedException();
        }

        public async Task<Open5eResponse<Spell>> GetSpells(int limit = 9999)
        {
            var response = await ResponseHandler<Spell>($"/spells/?limit={limit}");

            if (response == null || response.Results == null) return null;

            return response;
        }

        public void GetWeapons()
        {
            throw new NotImplementedException();
        }
    }
}
