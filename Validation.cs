using System.Net;

using Uex = StarCitizenPricingBot.Contracts.Uex;

namespace StarCitizenPricingBot
{
    public static class Validation
    {
        public static bool ValidateUexData(Uex.VehiclesResponse vehiclesResponse, Uex.VehiclePurchasesPricesResponse vehiclePurchasePricesResponse, Uex.VehicleRentalPricesResponse vehicleRentalPricesResponse, Uex.TerminalsResponse terminalsResponse)
        {
            return ValidateVehicles(vehiclesResponse) 
                && ValidateVehiclePurchasePrices(vehiclePurchasePricesResponse) 
                && ValidateVehicleRentalPrices(vehicleRentalPricesResponse) 
                && ValidateTerminals(terminalsResponse);
        }

        public static bool ValidateVehicles(Uex.VehiclesResponse vehiclesResponse)
        {
            var isValid = true;

            if( vehiclesResponse.HttpStatusCode != ((int)HttpStatusCode.OK))
            {
                isValid = false;
                if( !string.IsNullOrWhiteSpace(vehiclesResponse.Message))
                {
                    Console.WriteLine(vehiclesResponse.Message);
                }
                else
                {
                    Console.WriteLine($"Invalid vehicles StatusCode : {vehiclesResponse.HttpStatusCode}");
                }
            }
            else if( vehiclesResponse.Vehicles?.Any() != true)
            {
                isValid = false;
                Console.WriteLine("Vehicle data not found");
            }

            return isValid;
        }

        public static bool ValidateVehiclePurchasePrices(Uex.VehiclePurchasesPricesResponse vehiclePurchasePricesResponse)
        {
            var isValid = true;

            if( vehiclePurchasePricesResponse.HttpStatusCode != ((int)HttpStatusCode.OK))
            {
                isValid = false;
                if( !string.IsNullOrWhiteSpace(vehiclePurchasePricesResponse.Message))
                {
                    Console.WriteLine(vehiclePurchasePricesResponse.Message);
                }
                else
                {
                    Console.WriteLine($"Invalid vehicle purchase price StatusCode : {vehiclePurchasePricesResponse.HttpStatusCode}");
                }
            }
            else if( vehiclePurchasePricesResponse.VehiclePrices?.Any() != true)
            {
                isValid = false;
                Console.WriteLine("Vehicle purchase price data not found");
            }

            return isValid;
        }

        public static bool ValidateVehicleRentalPrices(Uex.VehicleRentalPricesResponse vehicleRentalPricesResponse)
        {
            var isValid = true;

            if( vehicleRentalPricesResponse.HttpStatusCode != ((int)HttpStatusCode.OK))
            {
                isValid = false;
                if( !string.IsNullOrWhiteSpace(vehicleRentalPricesResponse.Message))
                {
                    Console.WriteLine(vehicleRentalPricesResponse.Message);
                }
                else
                {
                    Console.WriteLine($"Invalid vehicle rental price StatusCode : {vehicleRentalPricesResponse.HttpStatusCode}");
                }
            }
            else if( vehicleRentalPricesResponse.VehiclePrices?.Any() != true)
            {
                isValid = false;
                Console.WriteLine("Vehicle rental price data not found");
            }

            return isValid;
        }

        public static bool ValidateTerminals(Uex.TerminalsResponse terminalsResponse)
        {
            var isValid = true;

            if( terminalsResponse.HttpStatusCode != ((int)HttpStatusCode.OK))
            {
                isValid = false;
                if( !string.IsNullOrWhiteSpace(terminalsResponse.Message))
                {
                    Console.WriteLine(terminalsResponse.Message);
                }
                else
                {
                    Console.WriteLine($"Invalid terminals StatusCode : {terminalsResponse.HttpStatusCode}");
                }
            }
            else if( terminalsResponse.Terminals?.Any() != true)
            {
                isValid = false;
                Console.WriteLine("Terminal data not found");
            }

            return isValid;
        }
    }
}