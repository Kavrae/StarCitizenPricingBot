using System.Text.Json.Serialization;

namespace StarCitizenPricingBot.Contracts.Uex
{
    public class UexCorpResponse
    {
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("http_code")]
        public int HttpStatusCode { get; set; }

        [JsonPropertyName("message")]
        public string? Message {get; set;}
    }
}