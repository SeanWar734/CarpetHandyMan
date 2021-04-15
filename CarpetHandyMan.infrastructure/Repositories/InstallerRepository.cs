using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Core.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.infrastructure.Repositories
{
    public class InstallerRepository : IInstallerRepository
    {
        private readonly CarpetContext _context;

        public InstallerRepository(CarpetContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Installer installer)
        {
            await _context.AddAsync(installer);
        }

        public async Task DeleteInstallerAsync(Guid InstallerId)
        {
            var installer = await _context.FindAsync<Installer>(InstallerId);
            _context.Remove(installer);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateInstaller(Installer installer)
        {
            _context.Entry(installer).State = EntityState.Modified;
        }
    }
}
