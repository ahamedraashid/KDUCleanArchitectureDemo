using Application.Common.Dtos;

namespace Application.Services.Interfaces
{
    public interface ICustomerService
    {
        CustomerDto GetCustomer(int id);

        void CreateCustomer(CustomerDto customerDto);

        //UPDATE

        //DELETE
    }
}
