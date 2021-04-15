using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Core.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.infrastructure.Repositories
{
    public class StaircaseRepository : IStaircaseRepository
    {
        private readonly CarpetContext _context;

        public StaircaseRepository(CarpetContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Staircase staircase)
        {
            await _context.AddAsync(staircase);
        }

        public async Task DeleteStaircaseAsync(Guid StaircaseId)
        {
            var staircase = await _context.FindAsync<Staircase>(StaircaseId);
            _context.Remove(staircase);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateStaircase(Staircase staircase)
        {
            _context.Entry(staircase).State = EntityState.Modified;
        }
    }
}
