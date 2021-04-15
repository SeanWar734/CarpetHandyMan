using CarpetHandyMan.Core.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Core.Interfaces
{
    public interface ICarpetRepository
    {
        Task AddAsync(Carpet carpet);
        Task DeleteCarpetAsync(Guid CarpetId);
        void UpdateCarpet(Carpet carpet);
        Task SaveAsync();
    }
}
