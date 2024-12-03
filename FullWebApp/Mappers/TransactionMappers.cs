using FullWebApp.DTOs.TransactionsDto;
using FullWebApp.Models;

namespace FullWebApp.Mappers;

public static class TransactionMappers
{
    public static Transactions ToTransactionFromCreateDto(this CreateTransactionDto transaction)
    {
        return new Transactions()
        {
            AccountId = transaction.AccountId,
            Value = transaction.Value,
            Title = transaction.Title,
            IsIncome = transaction.IsIncome
        };
    }
}