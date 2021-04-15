using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Core.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.infrastructure.Repositories
{
    public class BuildingRepository : IBuildingRepository
    {
        private readonly CarpetContext _context;

        public BuildingRepository(CarpetContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Building building)
        {
            await _context.AddAsync(building);
        }

        public async Task DeleteBuildingAsync(Guid BuildingId)
        {
            var building = await _context.FindAsync<Building>(BuildingId);
            _context.Remove(building);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateBuilding(Building building)
        {
            _context.Entry(building).State = EntityState.Modified;
        }
    }
}
