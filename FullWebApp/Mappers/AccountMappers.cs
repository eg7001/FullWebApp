using FullWebApp.DTOs.AccountDto;
using FullWebApp.Models;

namespace FullWebApp.Mappers;

public static class AccountMappers
{
    public static Account ToAccountFromDto(this CreateAccountDto dto,string appUserId)
    {
        return new Account
        {
            AppUserId = appUserId,
            Name = dto.Name,
            Type = dto.Type,
            Balance = dto.Balance
        };
    }
}