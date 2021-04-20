using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Staircases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Services
{
    public class StaircaseService : IStaircaseService
    {
        private HttpClient HttpClient { get; set; }

        public StaircaseService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task AddNewStaircaseAsync(CreateStaircaseRequest staircaseRequest)
        {
            var StaircaseRequestJson = new StringContent(JsonSerializer.Serialize(staircaseRequest), Encoding.UTF8, "application/json");
            await HttpClient.PostAsync($"staircase", StaircaseRequestJson);
        }

        public async Task DeleteStaircaseAsync(Guid id)
        {
            await HttpClient.DeleteAsync($"staircase/{id}");
        }

        public Task UpdateStaircaseAsync(UpdateStaircaseRequest staircaseRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StaircaseListResponse>> GetStaircaseByBuildingIdAsync(Guid id)
        {
            var result = await HttpClient.GetStreamAsync($"staircases/building/{id}");
            return await JsonSerializer.DeserializeAsync<List<StaircaseListResponse>>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
