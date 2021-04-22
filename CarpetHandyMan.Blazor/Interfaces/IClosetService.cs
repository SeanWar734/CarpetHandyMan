using CarpetHandyMan.Shared.Closets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Interfaces
{
    public interface IClosetService
    {
        Task<List<ClosetListResponse>> GetAllClosetByRoomIdAsync(Guid id);
        Task<List<ClosetListResponse>> GetAllClosetByBuildingIdAsync(Guid id);
        Task<ClosetSingleResponse> GetOneClosetAsync(Guid id);
        Task AddNewClosetAsync(CreateClosetRequest ClosetRequest);
        Task DeleteClosetAsync(Guid id);
        Task UpdateClosetAsync(UpdateClosetRequest ClosetRequest);
    }
}
