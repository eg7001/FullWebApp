using FullWebApp.Context;
using FullWebApp.Controllers;
using FullWebApp.DTOs.UserProfileDTOs;
using FullWebApp.Interfaces;
using FullWebApp.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace FullWebApp.Repositories;

public class UserProfileRepository : IUserProfileRepository

{
    private readonly ApplicationDbContext _dbContext;

    public UserProfileRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<UserProfile?> GetUserProfileById(int id)
    {
        return await _dbContext.UserProfiles.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<UserProfile?> CreateUserProfile(UserProfile profile)
    {
        await _dbContext.AddAsync(profile);
        await _dbContext.SaveChangesAsync();
        return profile;
    }

    public async Task<UserProfile?> UpdateUserProfile(int id, UserProfileDto userProfileDto)
    {
        var exists = await _dbContext.UserProfiles.FirstOrDefaultAsync(x => x.Id == id);
        if (exists == null)
        {
            return null;
        }

        exists.Email = userProfileDto.Email;
        exists.FirstName = userProfileDto.FirstName;
        exists.LastName = userProfileDto.LastName;

        await _dbContext.SaveChangesAsync();

        return exists;
    }

    public async Task<UserProfile?> DeleteAsync(int id)
    {
        var userProfileModel = await _dbContext.UserProfiles.FirstOrDefaultAsync(x => x.Id == id);
        if (userProfileModel == null)
        {
            return null;
        }

        _dbContext.UserProfiles.Remove(userProfileModel);
        await _dbContext.SaveChangesAsync();
        return userProfileModel;
    }
}