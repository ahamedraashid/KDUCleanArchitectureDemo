using Application.Common;
using Application.Common.Dtos;
using Application.Common.Interfaces;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using System.Linq;

namespace Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IApplicationContext _applicationContext;
        private readonly Mapper _mapper;

        public AccountService(IApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AccountDto, Account>();
                cfg.CreateMap<Account, AccountDto>();

            });

            _mapper = new Mapper(config);
        }
        public void CreateAccount(AccountDto accountDto)
        {
            var accountCount = _applicationContext.Account.Where(s => s.CustomerId == accountDto.CustomerId).Count();
            if (accountCount < Constants.ACCOUNTS_ALLOWED)
            {
                var account = _mapper.Map<Account>(accountDto);
                _applicationContext.Account.Add(account);

                _applicationContext.SaveChanges();
            }
            else
            {
                throw new System.Exception("user has 3 or more  accounts");
            }

        }

        public AccountDto GetAccount(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
