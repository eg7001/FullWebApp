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
     public static ReturnSavingsGoalDto ToReturnSavingDtoFromSaving(this SavingGoal savingGoal, string appUserId){
        return new ReturnSavingsGoalDto{
            AppUserId = appUserId,
            Name = savingGoal.Name,
            Target = savingGoal.Target,
            Current = savingGoal.Current,
            Deadline = savingGoal.Deadline
        };
    }
    /*
    public static List<ReturnSavingsGoalDto> ToSavingGoalDtos(this List<SavingGoal?> savingGoals)
    {
        List<ReturnSavingsGoalDto> savingsGoalDtos = new List<ReturnSavingsGoalDto>(savingGoals.Count());
        for(int i =1; i<savingGoals.Count() -1 ;i++){
            savingsGoalDtos[i] = new ReturnSavingsGoalDto{
                AppUserId = savingGoals[i].AppUserId,
                Name = savingGoals[i].Name,
                Target = savingGoals[i].Target,
                Current = savingGoals[i].Current,
                Deadline = savingGoals[i].Deadline
            };
        }
        return savingsGoalDtos;
    }*/
    
}