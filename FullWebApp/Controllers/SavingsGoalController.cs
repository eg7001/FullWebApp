using System.Runtime.InteropServices.JavaScript;

namespace FullWebApp.Controllers;

public class SavingsGoalController
{
    public int SavingsId { get; set; }
    public int? UserId { get; set; }
    public string? Name { get; set; }
    public double Target { get; set; }
    public double? Current { get; set; }
    public DateTime Deadline { get; set; }
    public DateTime CreatedAt{ get; set; } = DateTime.Now;
    
}