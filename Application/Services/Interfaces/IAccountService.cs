using Application.Common.Dtos;

namespace Application.Services.Interfaces
{
    public interface IAccountService
    {
        AccountDto GetAccount(int id);

        void CreateAccount(AccountDto customerDto);

        //UPDATE

        //DELETE
    }
}
