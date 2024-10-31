using FullWebApp.DTOs.AccountDto;
using FullWebApp.Models;

namespace FullWebApp.Mappers;

public static class AccountMappers
{
    public static Accounti ToAccountFromDto(this AccountDto dto)
    {
        return new Accounti
        {
            Id = dto.Id,
            Name = dto.Name,
            TransactionId = dto.TransactionId,
            Type = dto.Type,
            Balance = dto.Balance
        };
    }
}