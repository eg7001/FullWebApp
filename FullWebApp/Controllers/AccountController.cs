using FullWebApp.DTOs.AccountDto;
using FullWebApp.Interfaces;
using FullWebApp.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FullWebApp.Controllers;

[Route("api/account")]
[ApiController]
public class   AccountController: ControllerBase
{
    public IAccountRepository _accountRepo { get; set; }

    public AccountController(IAccountRepository accountRepo)
    {
        _accountRepo = accountRepo;
        
    }

    [Authorize]
    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        if (ModelState!.IsValid)
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
    public async Task<IActionResult> CreateAccount([FromBody] AccountDto dto)
    {
         if (ModelState!.IsValid)
         {
             return BadRequest(ModelState);
         }

         var account = dto.ToAccountFromDto();
         await _accountRepo.CreateAccount(account);
         return Ok(dto);
    }
}