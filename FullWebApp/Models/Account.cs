namespace FullWebApp.Models;

public class Account
{
    public int AccountId { get; set; }
    
    public string? AppUserId { get; set; }
    public AppUser? AppUser { get; set; }

    public int? TransactionId { get; set; }
    public List<Transaction> Transactions { get; set; }
    
    public string? Name { get; set; }
    public string? Type { get; set; }
    public double Balance { get; set; }
    
    
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}