using Newtonsoft.Json;
using Open5e_Data.Interfaces;
using Open5e_Data.Model;

namespace Open5e_Data.Servers
{
    internal class Open5eServer : IOpen5eServer
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

        public void GetClassesAsync()
        {
            throw new NotImplementedException();
        }

        public void GetConditionsAsync()
        {
            throw new NotImplementedException();
        }

        public void GetMagicItemsAsync()
        {
            throw new NotImplementedException();
        }

        public void GetMonstersAsync()
        {
            throw new NotImplementedException();
        }

        public void GetRacesAsync()
        {
            throw new NotImplementedException();
        }

        public void GetSectionsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Open5eResponse<Spell>> GetSpellsAsync(int limit = 9999)
        {
            var response = await ResponseHandler<Spell>($"/spells/?limit={limit}");

            if (response == null || response.Results == null) return null;

            return response;
        }

        public void GetWeaponsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
