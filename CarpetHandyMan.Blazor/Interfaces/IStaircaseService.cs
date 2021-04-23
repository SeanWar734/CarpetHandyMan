using CarpetHandyMan.Shared.Staircases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Interfaces
{
    public interface IStaircaseService
    {
        Task<StaircaseListResponse> GetStaircaseById(Guid id);
        Task<List<StaircaseListResponse>> GetStaircaseByBuildingIdAsync(Guid id);
        Task AddNewStaircaseAsync(CreateStaircaseRequest staircaseRequest);
        Task DeleteStaircaseAsync(Guid id);
        Task UpdateStaircaseAsync(UpdateStaircaseRequest staircaseRequest);
    }
}
