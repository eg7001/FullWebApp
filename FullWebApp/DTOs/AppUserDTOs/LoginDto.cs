using System.ComponentModel.DataAnnotations;

namespace FullWebApp.DTOs.AppUserDTOs;

public class LoginDto
{
    [Required] public string Username { get; set; }
    [Required] public string Password { get; set; }
}