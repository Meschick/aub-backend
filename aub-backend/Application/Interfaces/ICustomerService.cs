using aub_backend.Domain.Entities;

namespace aub_backend.Application.Interfaces
{
    public interface ICustomerService
    {
            // Retornar o DTO nao a entidade original 
            Task<Customer> AddCustomerAsync(Customer customer);
            Task<Customer?> GetCustomerByIdAsync(int id);
            Task<IEnumerable<Customer>> GetAllCustomersAsync();
            Task<Customer?> UpdateCustomerAsync(Customer customer);
            Task<bool> DeleteCustomerAsync(int id);
    }
}
