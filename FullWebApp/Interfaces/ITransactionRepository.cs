using System.Transactions;

namespace FullWebApp.Interfaces;

public interface ITransactionRepository
{
    Task<Transaction?> AddIncome(Transaction transaction);
    Task<Transaction?> AddExpense(Transaction transaction);
    Task<Transaction?> DeleteTransaction(int id);
    Task<List<Transaction?>> GetByUserProfile(int id);
    Task<List<Transaction?>> GetByAccount(int id);
}