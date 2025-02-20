using StarCitizenPricingBot;

var vehiclesResponse = await UexCorpProxy.GetVehiclesAll();
var vehiclePurchasePricesResponse = await UexCorpProxy.GetVehiclePurchasesPricesAll();
var vehicleRentalPricesResponse = await UexCorpProxy.GetVehicleRentalPricesAll();
var terminalsResponse = await UexCorpProxy.GetTerminalsAll();

if( Validation.ValidateUexData( vehiclesResponse, vehiclePurchasePricesResponse, vehicleRentalPricesResponse, terminalsResponse))
{
    var vehicles = DataEngine.FilterVehicles(vehiclesResponse.Vehicles);
    var vehiclePurchasePrices = DataEngine.FilterVehiclePurchasePrices(vehiclePurchasePricesResponse.VehiclePrices);
    var vehicleRentalPrices = DataEngine.FilterVehicleRentalPrices(vehicleRentalPricesResponse.VehiclePrices);
    var terminals = DataEngine.FilterTerminals(terminalsResponse.Terminals);
    
    if( vehicles.Length != 0 && vehiclePurchasePrices.Length != 0 && vehicleRentalPrices.Length != 0 && terminals.Length != 0)
    {
        var vehicleData = DataEngine.BuildVehicleData(vehicles, vehiclePurchasePrices, vehicleRentalPrices, terminals);
    }

    var test = "pause";
}

//TODO write json to single ship page
//TODO write to all ship pages
//TODO convert to bot