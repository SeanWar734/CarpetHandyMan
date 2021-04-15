using CarpetHandyMan.Core.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Core.Interfaces
{
    public interface ICustomerRepository
    {
        Task AddAsync(Customer customer);
        Task DeleteCustomerAsync(Guid CustomerId);
        void UpdateCustomer(Customer customer);
        Task SaveAsync();
    }
}
