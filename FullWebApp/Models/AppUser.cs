using Microsoft.AspNetCore.Identity;

namespace FullWebApp.Models;

public class AppUser : IdentityUser
{
    public int? UserProfileId { get; set; }
    public UserProfile UserProfile { get; set; }    
    public int? AccountId { get; set; }
    public List<Account> Accounts { get; set; }
    public int? SavingGoalId { get; set; }
    public List<SavingGoal> SavingGoals { get; set; }
}