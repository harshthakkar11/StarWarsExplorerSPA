using System.Net.Http.Json;
using StarWarsExplorer.Models;

public class SwapiService
{

    private readonly HttpClient _http;

    public SwapiService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Character>> GetCharactersAsync()
    {
        var response = await _http.GetFromJsonAsync<ApiListResponse<Character>>("people");
        return response?.Results ?? new();
    }

    public async Task<Character> GetCharacterByIdAsync(string id)
    {
        var response = await _http.GetFromJsonAsync<ApiItemResponse<Character>>($"people/{id}");
        return response?.Result;
    }

    public async Task<List<Planet>> GetPlanetsAsync()
    {
        var response = await _http.GetFromJsonAsync<ApiListResponse<Planet>>("planets");
        return response?.Results ?? new();
    }

    public async Task<Planet> GetPlanetByIdAsync(string id)
    {
        var response = await _http.GetFromJsonAsync<ApiItemResponse<Planet>>($"planets/{id}");
        return response?.Result;
    }

    public async Task<List<Species>> GetSpeciesAsync()
    {
        var response = await _http.GetFromJsonAsync<ApiListResponse<Species>>("species");
        return response?.Results ?? new();
    }

    public async Task<Species> GetSpeciesByIdAsync(string id)
    {
        var response = await _http.GetFromJsonAsync<ApiItemResponse<Species>>($"species/{id}");
        return response?.Result;
    }


}
