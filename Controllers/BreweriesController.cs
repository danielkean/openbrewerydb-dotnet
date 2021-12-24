using Microsoft.AspNetCore.Mvc;

namespace OpenBrewery;

[ApiController]
[Route("[controller]")]
public class BreweriesController : ControllerBase
{
    private readonly HttpClient client = new();
    private const string BASE_URL = "https://api.openbrewerydb.org/breweries/";

    [HttpGet]
    public Task<ActionResult<List<Brewery>>> ListBreweries()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public Task<ActionResult<Brewery>> GetBrewery(string id)
    {
        throw new NotImplementedException();
    }

    [HttpGet("search")]
    public Task<ActionResult<List<Brewery>>> SearchBreweries(string query)
    {
        throw new NotImplementedException();
    }
}
