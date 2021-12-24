using Microsoft.AspNetCore.Mvc;

namespace OpenBrewery;

[ApiController]
[Route("[controller]")]
public class BreweriesController : ControllerBase
{
    private readonly HttpClient client = new();
    private const string BASE_URL = "https://api.openbrewerydb.org/breweries/";

    /// <summary>
    /// Get a list of breweries through a collection of optional parameters.
    /// </summary>
    /// <returns>A list of breweries that match the parameters. If none are provided, return all breweries.</returns>
    [HttpGet]
    public async Task<ActionResult<List<Brewery>>> ListBreweries()
    {
        var breweries = await client.GetFromJsonAsync<List<Brewery>>($"{BASE_URL}{Request.QueryString}");
        return breweries == null ? NotFound() : breweries;
    }

    /// <summary>
    /// Get a brewery by id.
    /// </summary>
    /// <param name="id">The id of the brewery that should be returned.</param>
    /// <returns>The brewery that matches the 'id' if one exists.</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<Brewery>> GetBrewery(string id)
    {
        var brewery = await client.GetFromJsonAsync<Brewery>($"{BASE_URL}{id}");
        return brewery == null ? NotFound() : brewery;
    }

    /// <summary>
    /// Search breweries using a query.
    /// </summary>
    /// <param name="query">The query to use for searching the breweries.</param>
    /// <returns>List of breweries that match the search query.</returns>
    [HttpGet("search")]
    public async Task<ActionResult<List<Brewery>>> SearchBreweries(string query)
    {
        var breweries = await client.GetFromJsonAsync<List<Brewery>>($"{BASE_URL}search?query={query}");
        return breweries == null ? NotFound() : breweries;
    }
}
