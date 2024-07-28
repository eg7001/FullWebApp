using System.ComponentModel.DataAnnotations;

namespace FullWebApp.DTOs.AppUserDTOs;

public class RegisterDto
{
    [Required]
    public string? Username { get; set; }
    [Required]
    [EmailAddress]
    public string? Email{ get; set; }
    [Required]
    public string? Password { get; set; }
    
}