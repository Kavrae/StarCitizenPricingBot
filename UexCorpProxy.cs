using System.Net.Http.Json;

using Uex = StarCitizenPricingBot.Contracts.Uex;

namespace StarCitizenPricingBot
{
    public static class UexCorpProxy
    {
        private static readonly string ApiUrl = "https://api.uexcorp.space";
        private static readonly string ApiVersion = "2.0";
        private static readonly HttpClient client = new();

        private static string BuildUrl(string endpoint)
        {
            return $"{ApiUrl}/{ApiVersion}/{endpoint}";
        }

        private static async Task<T> GetData<T>( string endpoint ) 
            where T : Uex.UexCorpResponse, new()
        {
            T data = new();
            var response = await client.GetAsync(BuildUrl(endpoint));
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadFromJsonAsync<T>() ?? new T
                {
                    Message = $"Null response when retrieving {typeof(T)}"
                };
            }

            return data;
        }

        public static async Task<Uex.TerminalsResponse> GetTerminalsAll()
        {
            return await GetData<Uex.TerminalsResponse>("terminals");
        }

        public static async Task<Uex.VehiclesResponse> GetVehiclesAll()
        {
            return await GetData<Uex.VehiclesResponse>("vehicles");
        }

        public static async Task<Uex.VehiclePurchasesPricesResponse> GetVehiclePurchasesPricesAll()
        {
            return await GetData<Uex.VehiclePurchasesPricesResponse>("vehicles_purchases_prices_all");
        }

        public static async Task<Uex.VehicleRentalPricesResponse> GetVehicleRentalPricesAll()
        {
            return await GetData<Uex.VehicleRentalPricesResponse>("vehicles_rentals_prices_all");
        }
    }
}