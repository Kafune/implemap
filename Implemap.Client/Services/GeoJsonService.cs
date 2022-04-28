using Refit;

namespace Implemap.Client.Services;

public class GeoJsonService : IGeoJsonService
{
    private readonly IGeoJsonService _client;
    
    public GeoJsonService(IConfiguration configuration, HttpClient httpClient)
    {
        httpClient.BaseAddress = new Uri(configuration.GetSection("MyAppSettings").GetValue<string>("ApiUri"));
        _client = RestService.For<IGeoJsonService>(httpClient, new RefitSettings());
    }

    public async Task<List<string>> Get()
    {
        return await _client.Get();
    }
}