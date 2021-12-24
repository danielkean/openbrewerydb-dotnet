using Microsoft.AspNetCore.Mvc;

namespace OpenBrewery;

[ApiController]
[Route("[controller]")]
public class BreweriesController : ControllerBase
{
    private readonly HttpClient client = new();
    private const string BASE_URL = "https://api.openbrewerydb.org/breweries/";

    [HttpGet]
    public async Task<ActionResult<List<Brewery>>> ListBreweries()
    {
        var breweries = await client.GetFromJsonAsync<List<Brewery>>($"{BASE_URL}{Request.QueryString}");
        return breweries == null ? NotFound() : breweries;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Brewery>> GetBrewery(string id)
    {
        var brewery = await client.GetFromJsonAsync<Brewery>($"{BASE_URL}{id}");
        return brewery == null ? NotFound() : brewery;
    }

    [HttpGet("search")]
    public async Task<ActionResult<List<Brewery>>> SearchBreweries(string query)
    {
        var breweries = await client.GetFromJsonAsync<List<Brewery>>($"{BASE_URL}search?query={query}");
        return breweries == null ? NotFound() : breweries;
    }
}
