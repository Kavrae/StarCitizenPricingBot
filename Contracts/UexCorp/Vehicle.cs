using System.Text.Json.Serialization;

namespace StarCitizenPricingBot.Contracts.Uex
{
    public class Vehicle
    {
        [JsonPropertyName("is_loading_dock")]
        public int? CanLoadViaDock {get; set;}

        [JsonPropertyName("scu")]
        public int? CargoCapacity {get; set; }
    
        [JsonPropertyName("container_sizes")]
        public string? CargoContainerSizes {get; set; }
        
        [JsonPropertyName("is_docking")]
        public int? ContainsDockingPort {get; set;}
        
        [JsonPropertyName("is_hangar")]
        public int? ContainsHangar {get; set;}

        [JsonPropertyName("crew")]
        public string? Crew {get; set; }

        [JsonPropertyName("date_added")]
        public int? DateAddedTimestamp {get; set; }

        [JsonPropertyName("date_modified")]
        public int? DateModifiedTimestamp {get; set; }
        
        [JsonPropertyName("game_version")]
        public string? GameVersion {get; set;}

        [JsonPropertyName("height")]
        public int? Height {get; set;}

        [JsonPropertyName("fuel_hydrogen")]
        public int? HydrogenFuelCapacity {get; set;}
        
        [JsonPropertyName("is_addon")]
        public int? IsAddon {get; set;}
        
        [JsonPropertyName("is_boarding")]
        public int? IsBoarding {get; set;}
        
        [JsonPropertyName("is_bomber")]
        public int? IsBomber {get; set;}
        
        [JsonPropertyName("is_cargo")]
        public int? IsCargo {get; set;}
        
        [JsonPropertyName("is_carrier")]
        public int? IsCarrier {get; set;}
        
        [JsonPropertyName("is_civilian")]
        public int? IsCivilian {get; set;}
        
        [JsonPropertyName("is_concept")]
        public int? IsConcept {get; set;}
        
        [JsonPropertyName("is_construction")]
        public int? IsConstruction {get; set;}
        
        [JsonPropertyName("is_datarunner")]
        public int? IsDataRunner {get; set;}
        
        [JsonPropertyName("is_emp")]
        public int? IsEmp {get; set;}
        
        [JsonPropertyName("is_exploration")]
        public int? IsExploration {get; set;}
        
        [JsonPropertyName("is_ground_vehicle")]
        public int? IsGroundVehicle {get; set;}
        
        [JsonPropertyName("is_industrial")]
        public int? IsIndustrial {get; set;}
        
        [JsonPropertyName("is_interdiction")]
        public int? IsInterdiction {get; set;}
        
        [JsonPropertyName("is_medical")]
        public int? IsMedical {get; set;}
        
        [JsonPropertyName("is_military")]
        public int? IsMilitary {get; set;}
        
        [JsonPropertyName("is_mining")]
        public int? IsMining {get; set;}
        
        [JsonPropertyName("is_passenger")]
        public int? IsPassenger {get; set;}
        
        [JsonPropertyName("is_qed")]
        public int? IsQuantumEnforcement {get; set;}
        
        [JsonPropertyName("is_racing")]
        public int? IsRacing {get; set;}
        
        [JsonPropertyName("is_refinery")]
        public int? IsRefinery {get; set;}
        
        [JsonPropertyName("is_refuel")]
        public int? IsRefuel {get; set;}
        
        [JsonPropertyName("is_repair")]
        public int? IsRepair {get; set;}
        
        [JsonPropertyName("is_research")]
        public int? IsResearch {get; set;}
        
        [JsonPropertyName("is_salvage")]
        public int? IsSalvage {get; set;}
        
        [JsonPropertyName("is_scanning")]
        public int? IsScanning {get; set;}
        
        [JsonPropertyName("is_science")]
        public int? IsScience {get; set;}
        
        [JsonPropertyName("is_showdown_winner")]
        public int? IsShowndownWinner {get; set;}
        
        [JsonPropertyName("is_spaceship")]
        public int? IsSpaceship {get; set;}
        
        [JsonPropertyName("is_starter")]
        public int? IsStarter {get; set;}
        
        [JsonPropertyName("is_stealth")]
        public int? IsStealth {get; set;}
        
        [JsonPropertyName("is_tractor_beam")]
        public int? IsTractorBeam {get; set;}

        [JsonPropertyName("id")]
        public required int Id {get; set; }

        [JsonPropertyName("length")]
        public int? Length {get; set;}

        [JsonPropertyName("id_company")]
        public int? ManufacturerId {get; set; }

        [JsonPropertyName("company_name")]
        public string? ManufacturerName {get; set;}

        [JsonPropertyName("mass")]
        public int? Mass {get; set;}

        [JsonPropertyName("name")]
        public required string Name {get; set;}

        [JsonPropertyName("name_full")]
        public required string NameFull {get; set;}

        [JsonPropertyName("pad_type")]
        public string? PadType {get; set;}

        [JsonPropertyName("fuel_quantum")]
        public int? QuantumFuelCapacity {get; set;}

        [JsonPropertyName("id_parent")]
        public int? ShipSeriesId {get; set; }

        [JsonPropertyName("slug")]
        public string? Slug {get; set; }

        [JsonPropertyName("url_store")]
        public string? UrlStore {get; set;}

        [JsonPropertyName("url_brochure")]
        public string? UrlBrochure {get; set;}

        [JsonPropertyName("url_hotsite")]
        public string? UrlHotsite {get; set;}

        [JsonPropertyName("url_video")]
        public string? UrlVideo {get; set;}

        [JsonPropertyName("uuid")]
        public string? UuId {get; set; }

        [JsonPropertyName("ids_vehicles_loaners ")]
        public string? VehicleLoanerIds {get; set;}

        [JsonPropertyName("width")]
        public int? Width {get; set;}
    }
}