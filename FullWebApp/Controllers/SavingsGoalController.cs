using System.Runtime.InteropServices.JavaScript;
using FullWebApp.DTOs.SavigngsGoalDto;
using FullWebApp.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FullWebApp.Controllers;

[ApiController]
public class SavingsGoalController: ControllerBase
{
    private readonly ISavingsGoalRepository _savingsRepo;

    public SavingsGoalController(ISavingsGoalRepository savingsRepo)
    {
        _savingsRepo = savingsRepo;
    }
    [HttpPost]
    [Route("createSaving")]
    public async Task<IActionResult> CreateSavingsGoal(SavingsGoalDto dto)
    {
        return Ok("Hale tu e ba ");
    }

    [HttpGet]
    [Route("getById")]
    public async Task<IActionResult> GetSavingsById()
    {   
        return Ok(); 
    }
    
    [HttpGet]
    [Route("getByUser")]
    public async Task<IActionResult> GetSavingsGoalByUser( /* duhet me pas diqka qitu po qka se di*/)
    {
        return Ok("Aight");
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