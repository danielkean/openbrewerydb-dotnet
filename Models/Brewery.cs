using System.Text.Json.Serialization;

namespace OpenBrewery;

public class Brewery
{
    /*
        NOTE: Properties with two words have custom JSON property names
        as to match the 'snake_case' format that 'OpenBreweryDB' uses.
    */

    public string? Id { get; set; }
    public string Name { get; set; } = "";
    [JsonPropertyName("brewery_type")]
    public string BreweryType { get; set; } = "";
    public string Street { get; set; } = "";
    [JsonPropertyName("address_2")]
    public string? Address2 { get; set; }
    [JsonPropertyName("address_3")]
    public string? Address3 { get; set; }
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    [JsonPropertyName("county_province")]
    public string CountyProvince { get; set; } = "";
    [JsonPropertyName("postal_code")]
    public string PostalCode { get; set; } = "";
    public string Country { get; set; } = "";
    public string? Longitude { get; set; }
    public string? Latitude { get; set; }
    public string? Phone { get; set; }
    [JsonPropertyName("website_url")]
    public string? WebsiteUrl { get; set; }
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; set; }
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }
}
