using aub_backend.Application.DTOs;
using aub_backend.Application.Interfaces;
using aub_backend.Domain.Entities;
using aub_backend.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace aub_backend.Infrastructure.Persistence.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly AppDbContext _context;
        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<Customer> AddAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer;

        }

        public async Task<bool> DeleteAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null) return false; 

            _context.Customers.Remove(customer);

            return await _context.SaveChangesAsync() > 0;

        }

        public async Task<PagedResponse<Customer>> GetAllAsync(PaginationParams paginationParams)
        {
            var query = _context.Customers.AsQueryable();

            var totalCount = await query.CountAsync();

            var data = await query
                .Skip((paginationParams.PageNumber - 1) * paginationParams.PageSize)
                .Take(paginationParams.PageSize)
                .ToListAsync();

            return new PagedResponse<Customer>(
                    data,
                    totalCount,
                    paginationParams.PageNumber,
                    paginationParams.PageSize
            );
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<Customer?> UpdateAsync(Customer customer)
        {
            var customerToUpdate = await _context.Customers.FirstOrDefaultAsync(c => c.Id == customer.Id);

            if (customerToUpdate == null) return null;

            customerToUpdate.UpdateEntity(
                    customer.Name,
                    customer.Telephone,
                    customer.Email,
                    customer.Cpf,
                    customer.DateOfBirth
                );

            await _context.SaveChangesAsync();
            return customerToUpdate;

        }
    }
}
