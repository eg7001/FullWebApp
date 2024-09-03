using FullWebApp.Controllers;
using FullWebApp.DTOs.UserProfileDTOs;
using FullWebApp.Models;

namespace FullWebApp.Interfaces;

public interface IUserProfileRepository
{
    public Task<UserProfile?> CreateUserProfile(AddUserProfileDto dto);
    
}