using aub_backend.Application.DTOs;
using aub_backend.Application.Interfaces;
using aub_backend.Domain.Entities;
using AutoMapper;

namespace aub_backend.Application.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
        public async Task<PagedResponse<CustomerResponseDto>> GetAllCustomersAsync( PaginationParams paginationParams)
        {
            var customers = await _customerRepository.GetAllAsync(paginationParams);
            var dtoCustomer = _mapper.Map<List<CustomerResponseDto>>(customers.Data);

            return new PagedResponse<CustomerResponseDto>(
                dtoCustomer,
                customers.TotalCount,
                customers.CurrentPage,
                customers.TotalPages
            );

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
