using CarpetHandyMan.Core.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Core.Interfaces
{
    public interface IRetailerRepository
    {
        Task AddAsync(Retailer retailer);
        Task DeleteRetailerAsync(Guid RetailerId);
        void UpdateRetailer(Retailer retailer);
        Task SaveAsync();
    }
}
