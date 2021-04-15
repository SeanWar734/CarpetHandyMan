using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Core.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly CarpetContext _context;

        public OrderRepository(CarpetContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Order order)
        {
            await _context.AddAsync(order);
        }

        public async Task DeleteOrderAsync(Guid OrderId)
        {
            var order = await _context.FindAsync<Order>(OrderId);
            _context.Remove(order);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateOrder(Order order)
        {
            _context.Entry(order).State = EntityState.Modified;
        }
    }
}
