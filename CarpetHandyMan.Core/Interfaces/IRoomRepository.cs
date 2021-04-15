using CarpetHandyMan.Core.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Core.Interfaces
{
    public interface IRoomRepository
    {
        Task AddAsync(Room room);
        Task DeleteRoomAsync(Guid RoomId);
        void UpdateRoom(Room room);
        Task SaveAsync();
    }
}
