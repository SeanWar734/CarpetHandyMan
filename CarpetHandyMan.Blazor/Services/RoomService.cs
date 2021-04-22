using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Services
{
    public class RoomService : IRoomService
    {
        private HttpClient HttpClient { get; set; }

        public RoomService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task AddNewRoomAsync(CreateRoomRequest RoomRequest)
        {
            var RoomRequestJson = new StringContent(JsonSerializer.Serialize(RoomRequest), Encoding.UTF8, "application/json");
            await HttpClient.PostAsync($"room", RoomRequestJson);
        }

        public async Task DeleteRoomAsync(Guid id)
        {
            await HttpClient.DeleteAsync($"room/{id}");
        }

        public async Task<List<RoomListResponse>> GetAllRoomsByBuildingIdAsync(Guid BuildingId)
        {
            var result = await HttpClient.GetStreamAsync($"rooms/building/{BuildingId}");
            return await JsonSerializer.DeserializeAsync<List<RoomListResponse>>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<RoomSingleResponse> GetOneRoomAsync(Guid id)
        {
            var result = await HttpClient.GetStreamAsync($"room/{id}");
            return await JsonSerializer.DeserializeAsync<RoomSingleResponse>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public Task UpdateRoomAsync(UpdateRoomRequest RoomRequest)
        {
            throw new NotImplementedException();
        }
    }
}