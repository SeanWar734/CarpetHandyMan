using CarpetHandyMan.Core.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Core.Interfaces
{
    public interface IStairRepository
    {
        Task AddAsync(Stair stair);
        Task DeleteStairAsync(Guid StairId);
        void UpdateStair(Stair stair);
        Task SaveAsync();
    }
}
