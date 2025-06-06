﻿using FullWebApp.DTOs.TransactionsDto;
using FullWebApp.Interfaces;
using FullWebApp.Mappers;
using FullWebApp.Models;
using FullWebApp.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FullWebApp.Controllers;

[ApiController]
[Route("api/transactions")]
public class TransactionController : ControllerBase
{
    private readonly ITransactionRepository _transactionRepo;

    public TransactionController(ITransactionRepository transactionRepo)
    {
        _transactionRepo = transactionRepo;
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult?> CreateTransaction([FromBody] CreateTransactionDto transactionsDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _transactionRepo.CreateTransaction(transactionsDto.ToTransactionFromCreateDto());
        return Ok(transactionsDto);
    }

    [Authorize]
    [HttpDelete]
    [Route("delete/{id:int}")]
    public async Task<IActionResult> DeleteTransaction([FromRoute] int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var transaction = await _transactionRepo.DeleteTransaction(id);
        if (transaction == null)
        {
            return NotFound("Nuk u gjet");
        }
        return Ok(transaction);
    }

    [Authorize]
    [HttpGet]
    [Route("getByAccount/{id:int}")]
    public async Task<IActionResult> GetByAccount([FromRoute] int accId)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var transaction = await _transactionRepo.GetByAccount(accId);
        var transactionDtos = transaction.Select(s => s.ToReturnDtoFromTransaction());

        return Ok(transactionDtos);
    }
}