using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Core.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.infrastructure.Repositories
{
    public class RetailerRepository : IRetailerRepository
    {
        private readonly CarpetContext _context;

        public RetailerRepository(CarpetContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Retailer retailer)
        {
            await _context.AddAsync(retailer);
        }

        public async Task DeleteRetailerAsync(Guid RetailerId)
        {
            var retailer = await _context.FindAsync<Retailer>(RetailerId);
            _context.Remove(retailer);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateRetailer(Retailer retailer)
        {
            _context.Entry(retailer).State = EntityState.Modified;
        }
    }
}
