namespace FullWebApp.DTOs.UpdateSavingsGoalDto;

public class UpdateSavingsGoalDto
{
    public string? Name { get; set; }  
    public double Target {get;set; }
    public double? Current {get;set;}
    public DateTime? Deadline{get;set;}       
}