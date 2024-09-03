using FullWebApp.Context;
using FullWebApp.DTOs.UserProfileDTOs;
using FullWebApp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FullWebApp.Controllers;

public class UserProfieController
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IUserProfileRepository _profileRepo;

    public UserProfieController()
    {
        
    }
    [HttpPost]
    public async Task<IActionResult> CreateUserProfile([FromBody] AddUserProfileDto profileDto)
    {
        return 
    }
}