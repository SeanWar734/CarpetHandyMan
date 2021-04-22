using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Closets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Services
{
    public class ClosetService : IClosetService
    {
        private HttpClient HttpClient { get; set; }

        public ClosetService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task AddNewClosetAsync(CreateClosetRequest ClosetRequest)
        {
            var ClosetRequestJson = new StringContent(JsonSerializer.Serialize(ClosetRequest), Encoding.UTF8, "application/json");
            await HttpClient.PostAsync($"closet", ClosetRequestJson);
        }

        public async Task DeleteClosetAsync(Guid id)
        {
            await HttpClient.DeleteAsync($"closet/{id}");
        }

        public async Task<List<ClosetListResponse>> GetAllClosetByBuildingIdAsync(Guid id)
        {
            var result = await HttpClient.GetStreamAsync($"closet/building/{id}");
            return await JsonSerializer.DeserializeAsync<List<ClosetListResponse>>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<List<ClosetListResponse>> GetAllClosetByRoomIdAsync(Guid id)
        {
            var result = await HttpClient.GetStreamAsync($"closet/room/{id}");
            return await JsonSerializer.DeserializeAsync<List<ClosetListResponse>>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<ClosetSingleResponse> GetOneClosetAsync(Guid id)
        {
            var result = await HttpClient.GetStreamAsync($"closet/{id}");
            return await JsonSerializer.DeserializeAsync<ClosetSingleResponse>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public Task UpdateClosetAsync(UpdateClosetRequest ClosetRequest)
        {
            throw new NotImplementedException();
        }
    }
}
