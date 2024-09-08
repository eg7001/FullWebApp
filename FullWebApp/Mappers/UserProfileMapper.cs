using FullWebApp.DTOs.UserProfileDTOs;
using FullWebApp.Models;

namespace FullWebApp.Mappers;

public static class UserProfileMapper
{
    public static UserProfile ToUserProfileFromCreate(this UserProfileDto userProfileDto)
    {
        return new UserProfile()
        {
            Email = userProfileDto.Email,
            FirstName = userProfileDto.FirstName,
            LastName = userProfileDto.LastName
        };
    }

    public static UserProfileDto ToDtoFromProfile(this UserProfile userProfile)
    {
        return new UserProfileDto
        {
            Email = userProfile.Email,
            FirstName = userProfile.FirstName,
            LastName = userProfile.LastName
        };
    }
    
    
}