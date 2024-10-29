using FullWebApp.DTOs.AccountDto;
using FullWebApp.Interfaces;
using FullWebApp.Models;

namespace FullWebApp.Repositories;

public class AccountRepository: IAccountRepository
{
    public Task<Account?> GetAccountById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Account?> CreateAccount(UserProfile userProfile)
    {
        throw new NotImplementedException();
    }

    public Task<Account?> UpdateAccount(int id, AccountDto accountDto)
    {
        throw new NotImplementedException();
    }

    public Task<Account?> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}