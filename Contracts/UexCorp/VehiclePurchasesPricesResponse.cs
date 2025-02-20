using System.Text.Json.Serialization;

namespace StarCitizenPricingBot.Contracts.Uex
{
    public class VehiclePurchasesPricesResponse : UexCorpResponse
    {
        [JsonPropertyName("data")]
        public VehiclePurchasePrice[]? VehiclePrices { get; set; }
    }
}