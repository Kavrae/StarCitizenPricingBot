using System.Text.Json.Serialization;

namespace StarCitizenPricingBot.Contracts.Uex
{
    public class VehiclePrice
    {
        [JsonPropertyName("date_added")]
        public int? DateAddedTimestamp { get; set; }
        
        [JsonPropertyName("date_modified")]
        public int? DateModifiedTimestamp { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }
        
        [JsonPropertyName("id_terminal")]
        public int? TerminalId { get; set; }
        
        [JsonPropertyName("terminal_name")]
        public string? TerminalName { get; set; }
        
        [JsonPropertyName("id_vehicle")]
        public int? VehicleId { get; set; }
        
        [JsonPropertyName("vehicle_name")]
        public string? VehicleName { get; set; }
    }
}