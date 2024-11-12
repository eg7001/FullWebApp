using FullWebApp.DTOs.UserProfileDTOs;
using FullWebApp.Models;

namespace FullWebApp.Mappers;

public static class UserProfileMapper
{
    public static UserProfile ToUserProfileFromCreate(this UserProfileDto userProfileDto,string appUserId)
    {
        return new UserProfile()
        {
            AppUserId = appUserId,
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