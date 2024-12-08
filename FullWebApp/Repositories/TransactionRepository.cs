using System.Transactions;
using FullWebApp.Context;
using FullWebApp.DTOs.TransactionsDto;
using FullWebApp.Interfaces;
using FullWebApp.Mappers;
using FullWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FullWebApp.Repositories;

public class TransactionRepository : ITransactionRepository
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IAccountRepository _accountRepo;

    public TransactionRepository(ApplicationDbContext dbContext, IAccountRepository accountRepo)
    {
        _dbContext = dbContext;
        _accountRepo = accountRepo;
    }

    public async Task<Transactions?> CreateTransaction(Transactions transaction)
    {
        if (transaction.IsIncome == false)
        {
            var acc = await _accountRepo.GetAccountById(transaction.AccountId);
            acc.Balance = acc.Balance - transaction.Value;
            await _accountRepo.UpdateAccount(transaction.AccountId, acc.ToCreateDtoFromAccount());
        }

        if (transaction.IsIncome == true)
        {
            var acc = await _accountRepo.GetAccountById(transaction.AccountId);
            acc.Balance = acc.Balance + transaction.Value;
            await _accountRepo.UpdateAccount(transaction.AccountId, acc.ToCreateDtoFromAccount());
        }

        await _dbContext.Transactions.AddAsync(transaction);
        await _dbContext.SaveChangesAsync();

        return transaction;
    }

    public async Task<Transactions?> DeleteTransaction(int id)
    {
        var transaction = await _dbContext.Transactions.FirstOrDefaultAsync(x => x.Id == id);
        if (transaction == null)
        {
            return null;
        }

        if (transaction.IsIncome == false)
        {
            var acc = await _accountRepo.GetAccountById(transaction.AccountId);
            acc.Balance = acc.Balance + transaction.Value;
            await _accountRepo.UpdateAccount(transaction.AccountId, acc.ToCreateDtoFromAccount());
        }

        if (transaction.IsIncome == true)
        {
            var acc = await _accountRepo.GetAccountById(transaction.AccountId);
            acc.Balance = acc.Balance - transaction.Value;
            await _accountRepo.UpdateAccount(transaction.AccountId, acc.ToCreateDtoFromAccount());
        }

        _dbContext.Transactions.Remove(transaction);
        await _dbContext.SaveChangesAsync();
        return transaction;
    }

    public Task<Transactions?> UpdateTranasction(int id, UpdateTransactionDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<List<Transactions?>> GetByAccount(int id)
    {
        throw new NotImplementedException();
    }
}