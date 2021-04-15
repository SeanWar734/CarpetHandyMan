using CarpetHandyMan.Core.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Core.Interfaces
{
    public interface IClosetRepository
    {
        Task AddAsync(Closet closet);
        Task DeleteClosetAsync(Guid ClosetId);
        void UpdateCloset(Closet closet);
        Task SaveAsync();
    }
}
