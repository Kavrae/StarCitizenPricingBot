using Uex = StarCitizenPricingBot.Contracts.Uex;
using Wiki = StarCitizenPricingBot.Contracts.Wiki;

namespace StarCitizenPricingBot
{
    public static class Translator
    {
        public static Wiki.VehiclePricingData TranslateToVehiclePricingData(Uex.Vehicle vehicle, Wiki.VehiclePurchaseLocation[] vehiclePurchaseLocations, Wiki.VehiclePurchaseLocation[] vehicleRentalLocations)
        {
            return new Wiki.VehiclePricingData
            {
                CanPurchase = vehiclePurchaseLocations.Length != 0,
                CanRent = vehicleRentalLocations.Length != 0,
                Id = vehicle.Id,
                Name = vehicle.Name,
                NameFull = vehicle.NameFull,
                PurchaseLocations = vehiclePurchaseLocations,
                RentalLocations = vehicleRentalLocations
            };
        }

        public static Wiki.VehiclePurchaseLocation TranslateToPurchaseLocation( Uex.VehiclePurchasePrice vehiclePurchasePrice, Uex.Terminal terminal)
        {
            return new Wiki.VehiclePurchaseLocation
            {
                CityName = terminal.CityName,
                CompanyName = terminal.CompanyName,
                DateAdded = TranslateToWikiDateFormat(vehiclePurchasePrice.DateAddedTimestamp ?? 0),
                DateModified = TranslateToWikiDateFormat(vehiclePurchasePrice.DateModifiedTimestamp ?? 0),
                FactionName = terminal.FactionName,
                MoonName = terminal.MoonName,
                OrbitName = terminal.OrbitName,
                OutpostName = terminal.OutpostName,
                PlanetName = terminal.PlanetName,
                Price = vehiclePurchasePrice.Price,
                SpaceStationName = terminal.SpaceStationName,
                StarSystemName = terminal.StarSystemName,
                TerminalName = terminal.Name
            };
        }
        public static Wiki.VehiclePurchaseLocation TranslateToPurchaseLocation( Uex.VehicleRentalPrice vehicleRentalPrice, Uex.Terminal terminal)
        {
            return new Wiki.VehiclePurchaseLocation
            {
                CityName = terminal.CityName,
                CompanyName = terminal.CompanyName,
                DateAdded = TranslateToWikiDateFormat(vehicleRentalPrice.DateAddedTimestamp ?? 0),
                DateModified = TranslateToWikiDateFormat(vehicleRentalPrice.DateModifiedTimestamp ?? 0),
                FactionName = terminal.FactionName,
                MoonName = terminal.MoonName,
                OrbitName = terminal.OrbitName,
                OutpostName = terminal.OutpostName,
                PlanetName = terminal.PlanetName,
                Price = vehicleRentalPrice.Price,
                SpaceStationName = terminal.SpaceStationName,
                StarSystemName = terminal.StarSystemName,
                TerminalName = terminal.Name
            };
        }

        public static string TranslateToWikiDateFormat( int timestamp)
        {
            return DateTimeOffset.FromUnixTimeSeconds(timestamp).UtcDateTime.ToString("yyyy-MM-dd");
        }
    }
}