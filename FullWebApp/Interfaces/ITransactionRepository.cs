using System.Transactions;

namespace FullWebApp.Interfaces;

public interface ITransactionRepository
{
    Task<Transaction?> AddIncome(int value);
    Task<Transaction?> AddExpense(int value);
    Task<Transaction?> DeleteTransaction(int id);
    Task<List<Transaction?>> GetByUserProfile(int id);
    Task<List<Transaction?>> GetByAccount(int id);
}