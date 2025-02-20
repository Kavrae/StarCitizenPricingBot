using System.Text.Json.Serialization;

namespace StarCitizenPricingBot.Contracts.Uex
{
    public class TerminalsResponse : UexCorpResponse
    {
        [JsonPropertyName("data")]
        public Terminal[]? Terminals { get; set; }
    }
}