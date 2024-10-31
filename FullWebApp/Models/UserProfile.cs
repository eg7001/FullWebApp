using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FullWebApp.Models;

public class UserProfile
{
    
    public int Id { get; set; }
    [ForeignKey("AppUser")]
    public string? AppUserId { get; set; }
    
    public AppUser AppUser { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
}