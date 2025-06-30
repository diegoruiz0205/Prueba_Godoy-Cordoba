
using System.Text.Json;

namespace Prueba_Api.Repositories
{
    public class GifRepository : IGifRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "suYBPvUFb3ZAtWCxBGZnYU17iIyB9wcf";
        public GifRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetGifUrlAsync(string query)
        {
            var url = $"https://api.giphy.com/v1/gifs/search?api_key={_apiKey}&q={query}&limit=10";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            var results = root.GetProperty("data").EnumerateArray().ToList();

            if (!results.Any())
                return null;

            // Seleccionar un GIF aleatorio
            var random = new Random();
            var selectedGif = results[random.Next(results.Count)];

            var gifUrl = selectedGif
                .GetProperty("images")
                .GetProperty("original")
                .GetProperty("url")
                .GetString();

            return gifUrl;
        }
    }
}
