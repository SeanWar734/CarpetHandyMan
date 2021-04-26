using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Retailers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Services
{
    public class RetailerService : IRetailerService
    {
        private HttpClient HttpClient { get; set; }

        public RetailerService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task AddNewRetailerAsync(CreateRetailerRequest RetailerRequest)
        {
            var RetailerRequestJson = new StringContent(JsonSerializer.Serialize(RetailerRequest), Encoding.UTF8, "application/json");
            await HttpClient.PostAsync($"retailer", RetailerRequestJson);
        }

        public async Task DeleteRetailerAsync(Guid id)
        {
            await HttpClient.DeleteAsync($"retailer/{id}");
        }

        public async Task<List<RetailerListResponse>> GetAllRetailersAsync()
        {
            var result = await HttpClient.GetStreamAsync($"retailer");
            return await JsonSerializer.DeserializeAsync<List<RetailerListResponse>>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<RetailerListResponse> GetOneRetailerAsync(Guid id)
        {
            var result = await HttpClient.GetStreamAsync($"retailer/{id}");
            return await JsonSerializer.DeserializeAsync<RetailerListResponse>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateRetailerAsync(UpdateRetailerRequest RetailerRequest)
        {
            var RetailerRequestJson = new StringContent(JsonSerializer.Serialize(RetailerRequest), Encoding.UTF8, "application/json");
            await HttpClient.PutAsync($"retailer", RetailerRequestJson);
        }
    }
}
