using CarpetHandyMan.Shared.Installers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Interfaces
{
    public interface IInstallerService
    {
        Task<List<InstallerListResponse>> GetAllInstallersByRetailerIdAsync(Guid id);
        Task<InstallerListResponse> GetOneInstallerAsync(Guid id);
        Task AddNewInstallerAsync(CreateInstallerRequest InstallerRequest);
        Task DeleteInstallerAsync(Guid id);
        Task UpdateInstallerAsync(UpdateInstallerRequest InstallerRequest);
    }
}
