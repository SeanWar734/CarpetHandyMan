using CarpetHandyMan.Shared.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Interfaces
{
    public interface IRoomService
    {
        Task<List<RoomListResponse>> GetAllRoomsByBuildingIdAsync(Guid BuildingId);
        Task<RoomSingleResponse> GetOneRoomAsync(Guid id);
        Task AddNewRoomAsync(CreateRoomRequest RoomRequest);
        Task DeleteRoomAsync(Guid id);
        Task UpdateRoomAsync(UpdateRoomRequest RoomRequest);
    }
}
