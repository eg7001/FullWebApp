using System.ComponentModel.DataAnnotations.Schema;

namespace FullWebApp.Models;

public class UserProfile
{
    public int UserId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
}