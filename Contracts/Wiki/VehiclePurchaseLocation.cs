using System.Text.Json.Serialization;

namespace StarCitizenPricingBot.Contracts.Wiki
{
    public class VehiclePurchaseLocation
    {
        [JsonPropertyName("cityName")]
        public required string? CityName {get; set;}

        [JsonPropertyName("companyName")]
        public required string? CompanyName {get; set;}

        [JsonPropertyName("dateAdded")]
        public required string? DateAdded {get; set;}

        [JsonPropertyName("dateModified")]
        public required string? DateModified {get; set;}

        [JsonPropertyName("factionName")]
        public required string? FactionName {get; set;}

        [JsonPropertyName("terminalName")]
        public required string? TerminalName {get; set;}
        
        [JsonPropertyName("orbitName")]
        public string? OrbitName {get; set;}
        
        [JsonPropertyName("outpostName")]
        public string? OutpostName {get; set;}
        
        [JsonPropertyName("planetName")]
        public string? PlanetName {get; set;}
        
        [JsonPropertyName("price")]
        public int? Price {get; set;}
        
        [JsonPropertyName("moonName")]
        public string? MoonName {get; set;}
        
        [JsonPropertyName("spaceStationName")]
        public string? SpaceStationName {get; set;}
        
        [JsonPropertyName("starSystemName")]
        public string? StarSystemName {get; set;}
    }
}