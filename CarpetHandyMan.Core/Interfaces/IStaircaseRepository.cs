using CarpetHandyMan.Core.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Core.Interfaces
{
    public interface IStaircaseRepository
    {
        Task AddAsync(Staircase staircase);
        Task DeleteStaircaseAsync(Guid StaircaseId);
        void UpdateStaircase(Staircase staircase);
        Task SaveAsync();
    }
}
