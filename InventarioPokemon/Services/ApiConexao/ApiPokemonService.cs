using InventarioPokemon.Models;
using Newtonsoft.Json;

namespace InventarioPokemon.Services.ApiConexao;

internal class ApiPokemonService
{
    private readonly HttpClient _httpClient = new();

    public async Task<PokeData> PegarRandomPokemonAsync()
    {
        int randomPokeId = new Random().Next(1, 1011);

        string apiUrl = $"https://pokeapi.co/api/v2/pokemon/{randomPokeId}";

        HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            PokeData pokemon = JsonConvert.DeserializeObject<PokeData>(responseBody)!;
            return pokemon;
        }
        else
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            throw new Exception($"Erro na solicitação à PokeAPI: {responseBody}");
        }
    }
}
