using aub_backend.Application.DTOs;
using aub_backend.Domain.Entities;

namespace aub_backend.Application.Interfaces
{
    public interface ICustomerRepository
    {
            Task<Customer> AddAsync(Customer customer);
            Task<Customer?> GetByIdAsync(int id);
            Task<PagedResponse<Customer>> GetAllAsync(PaginationParams paginationParams);
            Task<Customer?> UpdateAsync(Customer customer);
            Task<bool> DeleteAsync(int id);   
    }
}
