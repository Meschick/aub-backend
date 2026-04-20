using aub_backend.Application.DTOs;
using aub_backend.Domain.Entities;
using AutoMapper;

namespace aub_backend.Application.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerResponseDto>();
        }
    }
}
