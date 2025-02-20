using Uex = StarCitizenPricingBot.Contracts.Uex;
using Wiki = StarCitizenPricingBot.Contracts.Wiki;

namespace StarCitizenPricingBot
{
    public static class DataEngine
    {
        public static Wiki.VehiclePricingData[] BuildVehicleData(Uex.Vehicle[] vehicles, Uex.VehiclePurchasePrice[] purchasePrices, Uex.VehicleRentalPrice[] rentalPrices, Uex.Terminal[] terminals)
        {
            var vehiclePricingDataList = new List<Wiki.VehiclePricingData>();

            foreach( var vehicle in vehicles)
            {
                var vehiclePurchaseLocations = BuildVehiclePurchaseLocations(vehicle.Id, purchasePrices, terminals);
                var vehicleRentalLocations = BuildVehicleRentalLocations( vehicle.Id, rentalPrices, terminals);
                vehiclePricingDataList.Add( Translator.TranslateToVehiclePricingData(vehicle, vehiclePurchaseLocations, vehicleRentalLocations) );
            }

            return [.. vehiclePricingDataList];
        }

        public static Wiki.VehiclePurchaseLocation[] BuildVehiclePurchaseLocations(int vehicleId, Uex.VehiclePurchasePrice[] purchasePrices, Uex.Terminal[] terminals)
        {
            var vehiclePurchaseLocations = new List<Wiki.VehiclePurchaseLocation>();

            var vehiclePurchasePrices = purchasePrices.Where(purchasePrice =>  purchasePrice.VehicleId == vehicleId);
            foreach( var vehiclePurchasePrice in vehiclePurchasePrices)
            {
                var terminal = terminals.FirstOrDefault( terminal => terminal.Id == vehiclePurchasePrice.TerminalId);
                if(terminal != null)
                {
                    vehiclePurchaseLocations.Add(Translator.TranslateToPurchaseLocation( vehiclePurchasePrice, terminal));
                }
            }

            return [.. vehiclePurchaseLocations];
        }

        public static Wiki.VehiclePurchaseLocation[] BuildVehicleRentalLocations(int vehicleId, Uex.VehicleRentalPrice[] rentalPrices, Uex.Terminal[] terminals)
        {
            var vehicleRentalLocations = new List<Wiki.VehiclePurchaseLocation>();

            var vehicleRentalPrices = rentalPrices.Where(rentalPrice =>  rentalPrice.VehicleId == vehicleId);
            foreach( var vehicleRentalPrice in vehicleRentalPrices)
            {
                var terminal = terminals.FirstOrDefault( terminal => terminal.Id == vehicleRentalPrice.TerminalId);
                if(terminal != null)
                {
                    vehicleRentalLocations.Add(Translator.TranslateToPurchaseLocation( vehicleRentalPrice, terminal));
                }
            }

            return [.. vehicleRentalLocations];
        }

        public static Uex.Vehicle[] FilterVehicles(Uex.Vehicle[]? vehicles)
        {
            vehicles ??= [];
            
            return [.. vehicles
                .Where( vehicle =>
                    vehicle != null
                    && !string.IsNullOrWhiteSpace(vehicle.Name)
                    && vehicle.IsConcept != 1
                    && vehicle.IsAddon != 1)];
        }

        public static Uex.VehiclePurchasePrice[] FilterVehiclePurchasePrices(Uex.VehiclePurchasePrice[]? vehiclePurchasePrices)
        {
            vehiclePurchasePrices ??= [];

            return [.. vehiclePurchasePrices
                .Where( vehiclePurchasePrice => 
                    vehiclePurchasePrice != null
                    && vehiclePurchasePrice.TerminalId != null
                    && vehiclePurchasePrice.VehicleId != null
                    && vehiclePurchasePrice.Price > 0)];
        }
        
        public static Uex.VehicleRentalPrice[] FilterVehicleRentalPrices(Uex.VehicleRentalPrice[]? vehicleRentalPrices)
        {
            vehicleRentalPrices ??= [];

            return [.. vehicleRentalPrices
                .Where( vehicleRentalPrice => 
                    vehicleRentalPrice != null
                    && vehicleRentalPrice.TerminalId != null
                    && vehicleRentalPrice.VehicleId != null
                    && vehicleRentalPrice.Price > 0)];
        }

        public static Uex.Terminal[] FilterTerminals(Uex.Terminal[]? terminals)
        {
            terminals ??= [];

            return [.. terminals
                .Where( terminal => 
                    terminal != null
                    && (terminal.Type == "vehicle_buy" || terminal.Type == "vehicle_rent")
                    && terminal.IsAvailableLive == 1)];
        }
    }
}