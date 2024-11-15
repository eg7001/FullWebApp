using FullWebApp.Context;
using FullWebApp.DTOs.SavigngsGoalDto;
using FullWebApp.Interfaces;
using FullWebApp.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FullWebApp.Repositories;

public class SavingsGoalRepository : ISavingsGoalRepository
{
    private readonly ApplicationDbContext _dbContext;
    private readonly UserManager<AppUser> _userRepo;
    public SavingsGoalRepository(ApplicationDbContext dbContext, UserManager<AppUser> userRepo)
    {
        _dbContext = dbContext;
        _userRepo = userRepo;        
    }


    public async Task<SavingGoal?> CreateSavingGoal(SavingGoal savingGoal)
    {
       await _dbContext.AddAsync(savingGoal);
       await _dbContext.SaveChangesAsync();
        return savingGoal;
    }

    public Task<SavingGoal?> DeleteSavingGoal(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<SavingGoal?> GetSavingGoalById(int id)
    {
        return await _dbContext.SavingGoals.FirstOrDefaultAsync(x => x.Id == id);
    }
    public async Task<List<SavingGoal?>> GetSavingByUser(string appUserId){
       var savingGoal = _dbContext.SavingGoals.Where(a => a.AppUserId == appUserId);
       return await savingGoal.ToListAsync(); 
    }
    public Task<SavingGoal?> UpdateSavingGoal(int id, CreateSavingsGoalDto dto)
    {
        throw new NotImplementedException();
    }
}