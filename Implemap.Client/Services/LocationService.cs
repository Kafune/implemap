using Implemap.Client.Models;
using Refit;

namespace Implemap.Client.Services;

public class LocationService : ILocationService
{
    private readonly ILocationService _client;
    
    public LocationService(IConfiguration configuration, HttpClient httpClient)
    {
        httpClient.BaseAddress = new Uri(configuration.GetSection("MyAppSettings").GetValue<string>("ApiUri")!);
        _client = RestService.For<ILocationService>(httpClient, new RefitSettings());
    }

    public async Task<List<Location>> Get()
    {
        return await _client.Get();
    }
}