using System.Runtime.InteropServices.JavaScript;
using FullWebApp.DTOs.SavigngsGoalDto;
using FullWebApp.Extensions;
using FullWebApp.Interfaces;
using FullWebApp.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FullWebApp.Controllers;

[ApiController]
public class SavingsGoalController: ControllerBase
{
    private readonly ISavingsGoalRepository _savingsRepo;
    private readonly UserManager<AppUser> _userRepo;
    
    public SavingsGoalController(ISavingsGoalRepository savingsRepo, UserManager<AppUser> userRepo)
    {
        _savingsRepo = savingsRepo;
        _userRepo = userRepo;
    }
    [HttpPost]
    [Route("createSaving")]
    public async Task<IActionResult> CreateSavingsGoal([FromBody] CreateSavingsGoalDto dto)
    {
        if(!ModelState.IsValid){
            return BadRequest(ModelState);
        }
        var userName = User.GetUsername();
        var appUser = await _userRepo.FindByNameAsync(userName);

        var savingGoal = await _savingsRepo.CreateSavingGoal(dto.ToSavingGoalFromCreateDto(appUser.Id));

        return Ok(savingGoal);    
    }

    [HttpGet]
    [Route("getById/{id:int}")]
    public async Task<IActionResult> GetSavingsById([FromRoute] int id)
    {   
        if(!ModelState.IsValid){
            return BadRequest(ModelState);
        }
        var userName = User.GetUsername();
        var savingGoal = await _savingsRepo.GetSavingGoalById(id);
        return Ok(savingGoal.ToSavingDtoFromSaving(userName)); 
    }
    
    [HttpGet]
    [Route("getByUser")]
    public async Task<IActionResult> GetSavingsGoalByAccount() // duhet me pas diqka qitu po qka se di //////
    {
        if(!ModelState.IsValid){
            return BadRequest(ModelState);
        }
        var userName = User.GetUsername();
        var appUser = await _userRepo.FindByNameAsync(userName);
        var savingGoal = await _savingsRepo.GetSavingByUser(appUser.Id);
        return Ok(savingGoal);
    }

    [HttpPut]
    [Route("update{id:int}")]
    public async Task<IActionResult> UpdateSavingsGOal(SavingsGoalDto dto)
    {
        return Ok("Hale vllaqko prrrit");
    }
    
    [HttpDelete]
    [Route("deleteSavings{id:int}")]
    public async Task<IActionResult> DeleteSavingsGoal([FromRoute] int id)
    {
        return Ok("Ne punime e siper");
    }
   
}