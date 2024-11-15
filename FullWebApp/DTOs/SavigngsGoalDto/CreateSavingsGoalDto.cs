namespace FullWebApp.DTOs.SavigngsGoalDto;

public class CreateSavingsGoalDto
{
    public string? Name { get; set; }  
    public double Target {get;set; }
    public double? Current {get;set;}
    public DateTime? Deadline{get;set;}       
}