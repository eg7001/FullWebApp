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

    public static ReturnDto ToReturnDtoFromTransaction(this Transactions transactions)
    {
        return new ReturnDto()
        {
            AccountId = transactions.AccountId,
            Value = transactions.Value,
            Title = transactions.Title,
            IsIncome = transactions.IsIncome
        };
    }
}