using CarpetHandyMan.Shared.Carpets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Interfaces
{
    public interface ICarpetService
    {
        Task<List<CarpetListReponse>> GetAllCarpetAsync();
        Task<CarpetListReponse> GetOneCarpetAsync(Guid id);
        Task AddNewCarpetAsync(CreateCarpetRequest carpetRequest);
        Task DeleteCarpetAsync(Guid id);
        Task UpdateCarpetAsync(UpdateCarpetRequest carpetRequest);
    }
}
