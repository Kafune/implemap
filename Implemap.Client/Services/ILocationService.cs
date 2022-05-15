using Refit;
using Implemap.Client.Models;

namespace Implemap.Client.Services;

public interface ILocationService
{
    [Get("/api/Location")]
    Task<List<Location>> Get();
}