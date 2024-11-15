using FullWebApp.Controllers;
using FullWebApp.DTOs.SavigngsGoalDto;
using FullWebApp.Models;

namespace FullWebApp.Interfaces;

public interface ISavingsGoalRepository
{
    Task<SavingGoal?> CreateSavingGoal(SavingGoal saving);
    Task<SavingGoal?> GetSavingGoalById(int id);
    Task<List<SavingGoal?>> GetSavingByUser(string appUserId);
    Task<SavingGoal?> UpdateSavingGoal(int id, CreateSavingsGoalDto dto);
    Task<SavingGoal?> DeleteSavingGoal(int id);    
}