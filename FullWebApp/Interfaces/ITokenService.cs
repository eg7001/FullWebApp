using FullWebApp.Models;

namespace FullWebApp.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
}