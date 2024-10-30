using Microsoft.AspNetCore.Identity;

namespace FullWebApp.Models;

public class AppUser : IdentityUser
{
    public int? UserProfileId { get; set; }
    public UserProfile UserProfile { get; set; }
    public Account Account { get; set; }
    public int? SavingGoalId { get; set; }
    public List<SavingGoal> SavingGoals { get; set; }
}