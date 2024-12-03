using System.ComponentModel.DataAnnotations.Schema;

namespace FullWebApp.Models;

[Table("Transactions")]
public class Transactions
{
    public int Id { get; set; }
    public int AccountId{ get; set; }
    public Account Account { get; set; }
    public double Value { get; set; }
    public string? Title { get; set; }
    public bool IsIncome { get; set; } = false;
}