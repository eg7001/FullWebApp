namespace FullWebApp.DTOs.AppUserDTOs;

public class NewUserDto
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Token { get; set; }
    
    public int? AccountId { get; set; }
    public int? SavingsGoalId { get; set; }
}