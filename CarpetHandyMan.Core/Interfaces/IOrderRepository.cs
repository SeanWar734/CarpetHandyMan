using CarpetHandyMan.Core.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.Core.Interfaces
{
    public interface IOrderRepository
    {
        Task AddAsync(Order order);
        Task DeleteOrderAsync(Guid OrderId);
        void UpdateOrder(Order order);
        Task SaveAsync();
    }
}
