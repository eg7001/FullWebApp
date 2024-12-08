using System.Transactions;
using FullWebApp.DTOs.TransactionsDto;
using FullWebApp.Models;

namespace FullWebApp.Interfaces;

public interface ITransactionRepository
{
    Task<Transactions> CreateTransaction(Transactions transaction);
    Task<Transactions?> DeleteTransaction(int id);
    Task<Transactions?> UpdateTranasction(int id, UpdateTransactionDto dto);
    Task<List<Transactions?>> GetByAccount(int id);
}