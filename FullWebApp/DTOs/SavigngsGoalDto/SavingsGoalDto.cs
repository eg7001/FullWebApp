namespace FullWebApp.DTOs.SavigngsGoalDto;

public class SavingsGoalDto
{
    public string? AppUserName { get; set; }  
    public string? Name { get; set; }  
    public double Target {get;set; }
    public double? Current {get;set;}
    public DateTime? Deadline{get;set;}       
}