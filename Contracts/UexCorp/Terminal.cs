using System.Text.Json.Serialization;

namespace StarCitizenPricingBot.Contracts.Uex
{
    public class Terminal
    {
        [JsonPropertyName("id_city")]
        public int? CityId { get; set; }

        [JsonPropertyName("city_name")]
        public string? CityName { get; set; }

        [JsonPropertyName("id_company")]
        public int? CompanyId { get; set; }

        [JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        [JsonPropertyName("date_added")]
        public int? DateAddedTimestamp { get; set; }

        [JsonPropertyName("date_modified")]
        public int? DateModifiedTimestamp { get; set; }

        [JsonPropertyName("id_faction")]
        public int? FactionId { get; set; }

        [JsonPropertyName("faction_name")]
        public string? FactionName { get; set; }

        [JsonPropertyName("has_loading_dock")]
        public int? HasLoadingDock { get; set; }

        [JsonPropertyName("has_docking_port")]
        public int? HasDockingPort { get; set; }

        [JsonPropertyName("has_freight_elevator")]
        public int? HasFreightElevator { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("is_affinity_influenceable")]
        public int? IsAffinityInfluenceable { get; set; }

        [JsonPropertyName("is_auto_load")]
        public int? IsAutoLoad { get; set; }

        [JsonPropertyName("is_available")]
        public int? IsAvailable { get; set; }

        [JsonPropertyName("is_available_live")]
        public int? IsAvailableLive { get; set; }

        [JsonPropertyName("is_cargo_center")]
        public int? IsCargoCenter { get; set; }

        [JsonPropertyName("is_food")]
        public int? IsFood { get; set; }

        [JsonPropertyName("is_habitation")]
        public int? IsHabitation { get; set; }

        [JsonPropertyName("is_medical")]
        public int? IsMedical { get; set; }

        [JsonPropertyName("is_nqa")]
        public int? IsNoQuestionsAsked { get; set; }

        [JsonPropertyName("is_player_owned")]
        public int? IsPlayerOwned { get; set; }

        [JsonPropertyName("is_refinery")]
        public int? IsRefinery { get; set; }

        [JsonPropertyName("is_refuel")]
        public int? IsRefuel { get; set; }

        [JsonPropertyName("is_repair")]
        public int? IsRepair { get; set; }

        [JsonPropertyName("is_shop_fps")]
        public int? IsShopFps { get; set; }

        [JsonPropertyName("is_shop_vehicle")]
        public int? IsShopVehicle { get; set; }

        [JsonPropertyName("max_container_size")]
        public int? MaximumContainerSize { get; set; }

        [JsonPropertyName("id_moon")]
        public int? MoonId { get; set; }

        [JsonPropertyName("moon_name")]
        public string? MoonName { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("nickname")]
        public string? NickName { get; set; }

        [JsonPropertyName("id_orbit")]
        public int? OrbitId { get; set; }

        [JsonPropertyName("orbit_name")]
        public string? OrbitName { get; set; }

        [JsonPropertyName("id_outpost")]
        public int? OutpostId { get; set; }

        [JsonPropertyName("outpost_name")]
        public string? OutpostName { get; set; }

        [JsonPropertyName("id_planet")]
        public int? PlanetId { get; set; }

        [JsonPropertyName("planet_name")]
        public string? PlanetName { get; set; }

        [JsonPropertyName("id_poi")]
        public int? PointOfInterestId { get; set; }

        [JsonPropertyName("id_space_station")]
        public int? SpaceStationId { get; set; }

        [JsonPropertyName("space_station_name")]
        public string? SpaceStationName { get; set; }

        [JsonPropertyName("id_star_system")]
        public int? StarSystemId { get; set; }

        [JsonPropertyName("star_system_name")]
        public string? StarSystemName { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}