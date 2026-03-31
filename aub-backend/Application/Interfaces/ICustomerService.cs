using aub_backend.Application.DTOs;
using aub_backend.Domain.Entities;

namespace aub_backend.Application.Interfaces
{
    public interface ICustomerService
    {
            Task<Customer> AddCustomerAsync(Customer customer);
            Task<Customer?> GetCustomerByIdAsync(int id);
            Task<PagedResponse<Customer>> GetAllCustomersAsync(PaginationParams paginationParams);
            Task<Customer?> UpdateCustomerAsync(Customer customer);
            Task<bool> DeleteCustomerAsync(int id);
    }
}
