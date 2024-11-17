using System.Transactions;
using FullWebApp.Interfaces;

namespace FullWebApp.Repositories;

public class TransactionRepository : ITransactionRepository
{
    public Task<Transaction?> AddExpense(Transaction transaction)
    {
        throw new NotImplementedException();
    }

    public Task<Transaction?> AddIncome(Transaction transaction)
    {
        throw new NotImplementedException();
    }

    public Task<Transaction?> DeleteTransaction(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Transaction?>> GetByAccount(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Transaction?>> GetByUserProfile(int id)
    {
        throw new NotImplementedException();
    }
}