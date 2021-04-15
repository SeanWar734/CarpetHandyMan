using CarpetHandyMan.Core.Interfaces;
using CarpetHandyMan.Core.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarpetHandyMan.infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CarpetContext _context;

        public CustomerRepository(CarpetContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Customer customer)
        {
            await _context.AddAsync(customer);
        }

        public async Task DeleteCustomerAsync(Guid CustomerId)
        {
            var customer = await _context.FindAsync<Customer>(CustomerId);
            _context.Remove(customer);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
        }
    }
}
