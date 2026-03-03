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

        // Retornar o DTO nao a entidade original
        // Criar os dtos de response, create, update

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _customerRepository.GetAllAsync();
        }
        public Task<Customer?> GetCustomerByIdAsync(int id)
        {
            var customer = _customerRepository.GetByIdAsync(id);

            if(customer == null) throw new Exception("Cliente nao encontrado");

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
