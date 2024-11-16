namespace FullWebApp.Models;
public class Transaction
{
    public int Id { get; set; }
    public UserProfile UserProfile { get; set; }
    public int? AccountId{ get; set; }
    public Account Account { get; set; }
    public double Value { get; set; }
    public string? Title { get; set; }
    public bool IsIncome { get; set; }
}