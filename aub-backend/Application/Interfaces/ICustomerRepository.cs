using aub_backend.Domain.Entities;

namespace aub_backend.Application.Interfaces
{
    public interface ICustomerRepository
    {
            Task<Customer> AddAsync(Customer customer);
            Task<Customer?> GetByIdAsync(int id);
            Task<IEnumerable<Customer>> GetAllAsync();
            Task<Customer?> UpdateAsync(Customer customer);
            Task<bool> DeleteAsync(int id);   
    }
}
