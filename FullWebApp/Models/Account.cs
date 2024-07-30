namespace FullWebApp.Models;

public class Account
{
    public int AccountId { get; set; }
    public int UserId { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public double Balance { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}