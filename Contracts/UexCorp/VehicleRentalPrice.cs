using System.Text.Json.Serialization;

namespace StarCitizenPricingBot.Contracts.Uex
{
    public class VehicleRentalPrice : VehiclePrice
    {
        [JsonPropertyName("price_rent")]
        public int Price { get; set; }
    }
}