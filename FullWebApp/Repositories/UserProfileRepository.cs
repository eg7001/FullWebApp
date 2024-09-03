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
    public async Task<UserProfile?> CreateUserProfile(AddUserProfileDto dto)
    {
        UserProfile profile = new UserProfile
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email
        };
        _dbContext.AddAsync(profile);
        _dbContext.SaveChangesAsync();
        return profile;
    }
}