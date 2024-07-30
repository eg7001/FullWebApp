namespace FullWebApp.Models;

public class Transaction
{
    public int TransactionId { get; set; }
    public double Value { get; set; }
    public string? Title { get; set; }
    public bool IsIncime { get; set; }
    
    
}