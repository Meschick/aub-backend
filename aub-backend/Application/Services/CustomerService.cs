using aub_backend.Application.DTOs;
using aub_backend.Application.Interfaces;
using aub_backend.Domain.Entities;

namespace aub_backend.Application.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<PagedResponse<Customer>> GetAllCustomersAsync( PaginationParams paginationParams)
        {
            return await _customerRepository.GetAllAsync(paginationParams);
        }
        public Task<Customer?> GetCustomerByIdAsync(int id)
        {
            var customer = _customerRepository.GetByIdAsync(id);

            if(customer == null) throw new Exception("Cliente não encontrado");

            return customer;
        }
        public Task<Customer> AddCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
        public Task<Customer?> UpdateCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteCustomerAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
