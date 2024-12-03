using FullWebApp.DTOs.AccountDto;
using FullWebApp.Models;
using FullWebApp.Extensions;
namespace FullWebApp.Mappers;
using Microsoft.AspNetCore.Identity;
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

    public static ReturnAccountDto ToReturnFromAccount(this Account account){
        return new ReturnAccountDto{

            Name = account.Name,
            Type = account.Type,
            Balance = account.Balance
        };
    }

    public static CreateAccountDto ToCreateDtoFromAccount(this Account account)
    {
        return new CreateAccountDto
        {
            Name = account.Name,
            Type = account.Type,
            Balance = account.Balance
        };
    }
}