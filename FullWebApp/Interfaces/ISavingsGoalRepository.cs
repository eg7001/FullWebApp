using FullWebApp.Controllers;
using FullWebApp.DTOs.SavigngsGoalDto;
using FullWebApp.DTOs.UpdateSavingsGoalDto;
using FullWebApp.Models;

namespace FullWebApp.Interfaces;

public interface ISavingsGoalRepository
{
    Task<SavingGoal?> CreateSavingGoal(SavingGoal saving);
    Task<SavingGoal?> GetSavingGoalById(int id);
    Task<List<SavingGoal?>> GetSavingByUser(string appUserId);
    Task<SavingGoal?> UpdateSavingGoal(int id, UpdateSavingsGoalDto dto);
    Task<SavingGoal?> DeleteSavingGoal(int id);    
}