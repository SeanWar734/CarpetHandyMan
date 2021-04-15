using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Core.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.infrastructure.Repositories
{
    public class StairRepository : IStairRepository
    {
        private readonly CarpetContext _context;

        public StairRepository(CarpetContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Stair stair)
        {
            await _context.AddAsync(stair);
        }

        public async Task DeleteStairAsync(Guid StairId)
        {
            var stair = await _context.FindAsync<Stair>(StairId);
            _context.Remove(stair);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateStair(Stair stair)
        {
            _context.Entry(stair).State = EntityState.Modified;
        }
    }
}
