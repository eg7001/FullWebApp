using FullWebApp.Context;
using FullWebApp.DTOs.AccountDto;
using FullWebApp.Interfaces;
using FullWebApp.Mappers;
using FullWebApp.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace FullWebApp.Repositories;

public class AccountRepository: IAccountRepository
{
    private IAccountRepository _accountRepositoryImplementation;
    private readonly ApplicationDbContext _dbContext; 

    public AccountRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<Account?> GetAccountById(int id)
    {
        return await _dbContext.Accounts.FirstOrDefaultAsync(x => x.Id == id);
    }

     public async Task<Account?> CreateAccount(Account account)
    {
        await _dbContext.AddAsync(account);
        await _dbContext.SaveChangesAsync();
        return account;
    }

    public async Task<Account?> UpdateAccount(int id, CreateAccountDto accountDto)
    {
        var exists = await _dbContext.Accounts.FirstOrDefaultAsync(x => x.Id == id);
        if (exists == null)
        {
            return null;
        }
        exists.Name = accountDto.Name;
        exists.Type = accountDto.Type;
        exists.Balance = accountDto.Balance;

        await _dbContext.SaveChangesAsync();

        return exists;
    }

    public async Task<Account?> DeleteAsync(int id)
    {
        var acountModel = await _dbContext.Accounts.FirstOrDefaultAsync(x => x.Id == id);
        if (acountModel == null)
        {
            return null;
        }

        _dbContext.Accounts.Remove(acountModel);
        await _dbContext.SaveChangesAsync();
        return acountModel;
    }
}