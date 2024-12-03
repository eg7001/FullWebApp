namespace FullWebApp.DTOs.TransactionsDto;

public class CreateTransactionDto
{
    public int AccountId{ get; set; }
    public double Value { get; set; }
    public string? Title { get; set; }
    public bool IsIncome { get; set; } = false;
}