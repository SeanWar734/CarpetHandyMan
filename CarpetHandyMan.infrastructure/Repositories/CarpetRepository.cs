using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Core.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.infrastructure.Repositories
{
    public class CarpetRepository : ICarpetRepository
    {
        private readonly CarpetContext _context;

        public CarpetRepository(CarpetContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Carpet carpet)
        {
            await _context.AddAsync(carpet);
        }

        public async Task DeleteCarpetAsync(Guid CarpetId)
        {
            var carpet = await _context.FindAsync<Carpet>(CarpetId);
            _context.Remove(carpet);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateCarpet(Carpet carpet)
        {
            _context.Entry(carpet).State = EntityState.Modified;
        }
    }
}
