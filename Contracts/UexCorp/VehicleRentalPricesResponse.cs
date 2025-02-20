using System.Text.Json.Serialization;

namespace StarCitizenPricingBot.Contracts.Uex
{
    public class VehicleRentalPricesResponse : UexCorpResponse
    {
        [JsonPropertyName("data")]
        public VehicleRentalPrice[]? VehiclePrices { get; set; }
    }
}