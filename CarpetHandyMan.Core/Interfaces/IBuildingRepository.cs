using CarpetHandyMan.Core.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Core.Interfaces
{
    public interface IBuildingRepository
    {
        Task AddAsync(Building building);
        Task DeleteBuildingAsync(Guid BuildingId);
        void UpdateBuilding(Building building);
        Task SaveAsync();
    }
}
