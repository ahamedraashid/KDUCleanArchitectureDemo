using Application.Common.Dtos;
using Application.Common.Interfaces;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IApplicationContext _applicationContext;
        private readonly Mapper _mapper;

        public CustomerService(IApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;

            _applicationContext = applicationContext;
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CustomerDto, Customer>();
                cfg.CreateMap<Customer, CustomerDto>();

            });

            _mapper = new Mapper(config);
        }
        public void CreateCustomer(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            _applicationContext.Customer.Add(customer);

            _applicationContext.SaveChanges();
        }

        public CustomerDto GetCustomer(int id)
        {
            var customer = _applicationContext.Customer.Find(id);
            return _mapper.Map<CustomerDto>(customer);
        }
    }
}
