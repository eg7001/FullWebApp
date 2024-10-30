namespace FullWebApp.DTOs.AccountDto;

public class AccountDto
{
    public string? Id{ get; set; }
    public int? TransactionId { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public double Balance { get; set; }
}