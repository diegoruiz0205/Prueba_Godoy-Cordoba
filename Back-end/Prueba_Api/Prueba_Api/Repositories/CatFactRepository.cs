using Prueba_Api.Models;
using System.Text.Json;

namespace Prueba_Api.Repositories
{
    public class CatFactRepository : ICatFactRepository


    {
        private readonly HttpClient _httpClient;


        public CatFactRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CastFact> GetRandomFactAsync()
        {
            var response = await _httpClient.GetAsync("https://catfact.ninja/fact");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<CastFact>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}
