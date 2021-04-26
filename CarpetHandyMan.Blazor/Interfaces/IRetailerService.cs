using CarpetHandyMan.Shared.Retailers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarpetHandyMan.Blazor.Interfaces
{
    public interface IRetailerService
    {
        Task<List<RetailerListResponse>> GetAllRetailersAsync();
        Task<RetailerListResponse> GetOneRetailerAsync(Guid id);
        Task AddNewRetailerAsync(CreateRetailerRequest RetailerRequest);
        Task DeleteRetailerAsync(Guid id);
        Task UpdateRetailerAsync(UpdateRetailerRequest RetailerRequest);
    }
}
