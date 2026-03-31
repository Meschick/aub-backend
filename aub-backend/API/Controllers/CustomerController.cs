using aub_backend.Application.DTOs;
using aub_backend.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aub_backend.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomer([FromQuery] PaginationParams paginationParams)
        {
            var customers = await _customerService.GetAllCustomersAsync(paginationParams);
            return Ok(customers);

        }
    }
}
