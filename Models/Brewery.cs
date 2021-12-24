namespace OpenBrewery;

public class Brewery
{
    public string? Id { get; set; }
    public string Name { get; set; } = "";
    public string BreweryType { get; set; } = "";
    public string Street { get; set; } = "";
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string CountyProvince { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string Country { get; set; } = "";
    public string? Longitude { get; set; }
    public string? Latitude { get; set; }
    public string? Phone { get; set; }
    public string? WebsiteUrl { get; set; }
    public string? UpdatedAt { get; set; }
    public string? CreatedAt { get; set; }
}
