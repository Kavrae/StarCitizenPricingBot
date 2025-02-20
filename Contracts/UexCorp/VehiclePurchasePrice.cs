using System.Text.Json.Serialization;

namespace StarCitizenPricingBot.Contracts.Uex
{
    public class VehiclePurchasePrice : VehiclePrice
    {
        [JsonPropertyName("price_buy")]
        public int Price { get; set; }
    }
}