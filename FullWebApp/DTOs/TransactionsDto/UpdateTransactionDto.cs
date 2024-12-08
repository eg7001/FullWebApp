namespace FullWebApp.DTOs.TransactionsDto;

public class UpdateTransactionDto
{
    public double Value { get; set; }
    public string? Title { get; set; }
    public bool IsIncome { get; set; } = false;
}