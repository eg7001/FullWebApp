namespace FullWebApp.Models;

public class SavingGoal
{
    public int Id { get; set; }
    public string? AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public string? Name { get; set; }
    public double Target { get; set; }
    public double? Current { get; set; }
    public DateTime? Deadline { get; set; }
    public DateTime CreatedAt{ get; set; } = DateTime.Now;
}