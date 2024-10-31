using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FullWebApp.Models;

[Table("AppUser")]
public class AppUser : IdentityUser
{
  
    public int? SavingGoalId { get; set; } 
    public List<SavingGoal> SavingGoals { get; set; } = new List<SavingGoal>();
}