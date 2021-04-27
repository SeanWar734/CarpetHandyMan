using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Installers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Services
{
    public class InstallerService : IInstallerService
    {

        private HttpClient HttpClient { get; set; }

        public InstallerService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
        
        public async Task AddNewInstallerAsync(CreateInstallerRequest InstallerRequest)
        {
            var InstallerRequestJson = new StringContent(JsonSerializer.Serialize(InstallerRequest), Encoding.UTF8, "application/json");
            await HttpClient.PostAsync($"installers", InstallerRequestJson);
        }

        public async Task DeleteInstallerAsync(Guid id)
        {
            await HttpClient.DeleteAsync($"installers/{id}");
        }

        public async Task<List<InstallerListResponse>> GetAllInstallersByRetailerIdAsync(Guid id)
        {
            var result = await HttpClient.GetStreamAsync($"installers/retailer/{id}");
            return await JsonSerializer.DeserializeAsync<List<InstallerListResponse>>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<InstallerListResponse> GetOneInstallerAsync(Guid id)
        {
            var result = await HttpClient.GetStreamAsync($"installers/{id}");
            return await JsonSerializer.DeserializeAsync<InstallerListResponse>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateInstallerAsync(UpdateInstallerRequest InstallerRequest)
        {
            var InstallerRequestJson = new StringContent(JsonSerializer.Serialize(InstallerRequest), Encoding.UTF8, "application/json");
            await HttpClient.PutAsync($"installers", InstallerRequestJson);
        }
    }
}
