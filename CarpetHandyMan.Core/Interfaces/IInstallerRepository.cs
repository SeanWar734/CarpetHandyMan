using CarpetHandyMan.Core.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Core.Interfaces
{
    public interface IInstallerRepository
    {
        Task AddAsync(Installer installer);
        Task DeleteInstallerAsync(Guid InstallerId);
        void UpdateInstaller(Installer installer);
        Task SaveAsync();
    }
}
