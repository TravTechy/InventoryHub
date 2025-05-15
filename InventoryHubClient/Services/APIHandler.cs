using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InventoryHubClient.Services
{
    public class APIHandler
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "http://localhost:5202/allitems";

        public APIHandler(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Items>> GetItemsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync(BaseUrl);
                response.EnsureSuccessStatusCode(); // Will throw if the status code is not successful (e.g., 404 or 500)

                var json = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    NumberHandling = JsonNumberHandling.AllowReadingFromString,
                };
                var items = JsonSerializer.Deserialize<List<Items>>(json, options);
                return items ?? new List<Items>();
            }
            catch (Exception ex)
            {
                // You can log the exception or handle it accordingly
                Console.WriteLine($"Error fetching items: {ex.Message}");
                return new List<Items>(); // Return an empty list or fallback data
            }
        }
    }
}
