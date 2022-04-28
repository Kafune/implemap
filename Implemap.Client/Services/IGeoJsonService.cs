using Refit;

namespace Implemap.Client.Services;

public interface IGeoJsonService
{
    [Get("/api/GeoJson")]
    Task<List<string>> Get();
}