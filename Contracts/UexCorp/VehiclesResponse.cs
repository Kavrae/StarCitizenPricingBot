using System.Text.Json.Serialization;

namespace StarCitizenPricingBot.Contracts.Uex
{
    public class VehiclesResponse : UexCorpResponse
    {
        [JsonPropertyName("data")]
        public Vehicle[]? Vehicles { get; set; }
    }
}