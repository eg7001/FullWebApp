using FullWebApp.Context;
using FullWebApp.DTOs.SavigngsGoalDto;
using FullWebApp.Interfaces;
using FullWebApp.Models;
using FullWebApp.Mappers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using FullWebApp.DTOs.UpdateSavingsGoalDto;

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

    public async Task<SavingGoal?> DeleteSavingGoal(int id)
    {
        var savingGoal = await _dbContext.SavingGoals.FirstOrDefaultAsync(x => x.Id == id);
        if(savingGoal == null){
            return null;
        }
        _dbContext.SavingGoals.Remove(savingGoal);
        await _dbContext.SaveChangesAsync();
        return savingGoal;
    }

    public async Task<SavingGoal?> GetSavingGoalById(int id)
    {
        return await _dbContext.SavingGoals.FirstOrDefaultAsync(x => x.Id == id);
    }
    public async Task<List<SavingGoal?>> GetSavingByUser(string appUserId){
       var savingGoal = _dbContext.SavingGoals.Where(a => a.AppUserId == appUserId);
       var goals = await savingGoal.ToListAsync();

       return goals;
    }
    public async Task<SavingGoal?> UpdateSavingGoal(int id, UpdateSavingsGoalDto dto)
    {
        var savingGoal = await _dbContext.SavingGoals.FirstOrDefaultAsync(x => x.Id == id);
        if(savingGoal == null){
            return null;
        }
        savingGoal.Name = dto.Name;
        savingGoal.Target = dto.Target;
        savingGoal.Current = dto.Current;
        savingGoal.Deadline = dto.Deadline; 
        await _dbContext.SaveChangesAsync();
        return savingGoal;
    }
}