using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Core.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.infrastructure.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly CarpetContext _context;

        public RoomRepository(CarpetContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Room room)
        {
            await _context.AddAsync(room);
        }

        public async Task DeleteRoomAsync(Guid RoomId)
        {
            var room = await _context.FindAsync<Room>(RoomId);
            _context.Remove(room);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateRoom(Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
        }
    }
}
