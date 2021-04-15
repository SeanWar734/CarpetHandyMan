using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Core.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.infrastructure.Repositories
{
    public class ClosetRepository : IClosetRepository
    {
        private readonly CarpetContext _context;

        public ClosetRepository(CarpetContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Closet closet)
        {
            await _context.AddAsync(closet);
        }

        public async Task DeleteClosetAsync(Guid ClosetId)
        {
            var closet = await _context.FindAsync<Closet>(ClosetId);
            _context.Remove(closet);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateCloset(Closet closet)
        {
            _context.Entry(closet).State = EntityState.Modified;
        }
    }
}
