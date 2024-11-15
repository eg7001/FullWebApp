using FullWebApp.DTOs.SavigngsGoalDto;
using FullWebApp.Models;

public static class SavingGoalMappers{
    public static SavingGoal ToSavingGoalFromDto(this SavingsGoalDto dto, string appUsrId){
        return new SavingGoal{
            AppUserId = appUsrId,
            Name= dto.Name,
            Target = dto.Target,
            Current = dto.Current,
            Deadline = dto.Deadline
        };
    }
public static SavingGoal ToSavingGoalFromCreateDto(this CreateSavingsGoalDto dto, string appUsrId){
        return new SavingGoal{
            AppUserId = appUsrId,
            Name= dto.Name,
            Target = dto.Target,
            Current = dto.Current,
            Deadline = dto.Deadline
        };
    }
    public static SavingsGoalDto ToSavingDtoFromSaving(this SavingGoal savingGoal, string userName){
        return new SavingsGoalDto{
            AppUserName = userName,
            Name = savingGoal.Name,
            Target = savingGoal.Target,
            Current = savingGoal.Current,
            Deadline = savingGoal.Deadline
        };
    }
}