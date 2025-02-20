using System.Text.Json.Serialization;

namespace StarCitizenPricingBot.Contracts.Wiki
{
    public class VehiclePricingData
    {
        [JsonPropertyName("canRent")]
        public required bool CanRent {get; set;}

        [JsonPropertyName("canPurchase")]
        public required bool CanPurchase {get; set;}

        [JsonPropertyName("id")]
        public required int Id {get; set;}

        [JsonPropertyName("name")]
        public required string Name {get; set;}

        [JsonPropertyName("nameFull")]
        public required string NameFull {get; set;}

        [JsonPropertyName("purchaseLocations")]
        public VehiclePurchaseLocation[]? PurchaseLocations {get; set;}

        [JsonPropertyName("rentalLocations")]
        public VehiclePurchaseLocation[]? RentalLocations {get; set;}
    }
}