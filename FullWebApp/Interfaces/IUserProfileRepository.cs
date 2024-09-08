using FullWebApp.Controllers;
using FullWebApp.DTOs.UserProfileDTOs;
using FullWebApp.Models;

namespace FullWebApp.Interfaces;

public interface IUserProfileRepository
{
    Task<UserProfile?> GetUserProfileById(int id);
    Task<UserProfile?> CreateUserProfile(UserProfile userProfile);
    Task<UserProfile?> UpdateUserProfile(int id, UserProfileDto userProfileDto);
    Task<UserProfile?> DeleteAsync(int id);
}