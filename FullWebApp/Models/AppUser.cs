using Microsoft.AspNetCore.Identity;

namespace FullWebApp.Models;

public class AppUser : IdentityUser
{
    public List<Account> Accounts { get; set; }
}