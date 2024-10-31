using FullWebApp.DTOs.AccountDto;
using FullWebApp.Models;

namespace FullWebApp.Interfaces;

public interface IAccountRepository
{
    Task<Accounti?> GetAccountById (int id);
    Task<Accounti?> CreateAccount(Accounti account);
    Task<Accounti?> UpdateAccount(int id, AccountDto accountDto);
    Task<Accounti?> DeleteAsync(int id); 
}