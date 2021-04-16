using CarpetHandyMan.Blazor.Interfaces;
using CarpetHandyMan.Shared.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        public Task AddNewRoomAsync(CreateRoomRequest RoomRequest)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRoomAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RoomListResponse>> GetAllRoomsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<RoomListResponse>> GetAllRoomsByBuildingIdAsync(Guid BuildingId)
        {
            var result = await HttpClient.GetStreamAsync($"rooms/building/{BuildingId}");
            return await JsonSerializer.DeserializeAsync<List<RoomListResponse>>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public Task<RoomSingleResponse> GetOneRoomAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRoomAsync(UpdateRoomRequest RoomRequest)
        {
            throw new NotImplementedException();
        }
    }
}