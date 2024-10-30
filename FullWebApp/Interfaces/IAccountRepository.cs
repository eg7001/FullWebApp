using FullWebApp.DTOs.AccountDto;
using FullWebApp.Models;

namespace FullWebApp.Interfaces;

public interface IAccountRepository
{
    Task<Account?> GetAccountById (int id);
    Task<Account?> CreateAccount(Account account);
    Task<Account?> UpdateAccount(int id, AccountDto accountDto);
    Task<Account?> DeleteAsync(int id); 
}