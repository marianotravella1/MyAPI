using Application.Interfaces;
using Domain.Entities;
using System.Text.Json;

namespace Application.Services
{
    public class JokeService : IJokeService
    {
        private readonly HttpClient _httpClient;

        public JokeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Joke>?> GetRandomJokesAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("https://official-joke-api.appspot.com/random_ten");
                
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    List<Joke>? jokes = JsonSerializer.Deserialize<List<Joke>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    
                    return jokes;
                }
                
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
    