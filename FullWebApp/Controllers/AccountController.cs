using FullWebApp.DTOs.AccountDto;
using FullWebApp.Interfaces;
using FullWebApp.Extensions;
using FullWebApp.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using FullWebApp.Models;

namespace FullWebApp.Controllers;

[Route("api/account")]
[ApiController]
public class   AccountController: ControllerBase
{
    private readonly IAccountRepository _accountRepo; 
    private readonly UserManager<AppUser> _userRepo;

    public AccountController(IAccountRepository accountRepo, UserManager<AppUser> userRepo)
    {
        _accountRepo = accountRepo;
        _userRepo = userRepo; 
    }

    [Authorize]
    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var account = await _accountRepo.GetAccountById(id);
        if (account == null)
        {
            return NotFound();
        }
        return Ok(account); // muj me ba qe me kthy edhe DTO
    }
    
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> CreateAccount([FromBody] CreateAccountDto dto)
    {
         if (!ModelState.IsValid)
         {
             return BadRequest(ModelState);
         }
         var userName = User.GetUsername();
         var appUser = await 
         _userRepo.FindByNameAsync(userName);

         var account = dto.ToAccountFromDto(appUser.Id);
         await _accountRepo.CreateAccount(account);
         return Ok(dto);
    }
    [Authorize]
    [HttpPut]
    [Route("{id:int}")]
    public async Task<IActionResult> UpdateAcount([FromRoute] int id, [FromBody] CreateAccountDto dto){
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }
            var accountModel = await _accountRepo.UpdateAccount(id,dto);
            if(accountModel == null){
                return BadRequest("This account doesn't exist");
            }
            

        return Ok(accountModel.ToReturnFromAccount());
    }

    [Authorize]
    [HttpDelete]
    [Route("removeAcc/{id:int}")]
    public async Task<IActionResult> DeleteAccount([FromRoute] int id){
        if(!ModelState.IsValid){
              return BadRequest(ModelState);
        }
        var account = await _accountRepo.DeleteAsync(id);
        if(account == null){
            return BadRequest("Account not found");
        }
        return Ok(account);
    }
}