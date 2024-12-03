using System.Transactions;
using FullWebApp.Models;

namespace FullWebApp.Interfaces;

public interface ITransactionRepository
{
    Task<Transactions> CreateTransaction(Transactions transaction);
    Task<Transactions?> DeleteTransaction(int id);
    Task<List<Transactions?>> GetByUserProfile(int id);
    Task<List<Transactions?>> GetByAccount(int id);
}