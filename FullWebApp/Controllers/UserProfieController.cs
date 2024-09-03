using FullWebApp.DTOs.UserProfileDTOs;
using FullWebApp.Interfaces;
using FullWebApp.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FullWebApp.Controllers;
[Route("api/userProfileController")]
[ApiController]
public class UserProfieController: ControllerBase
{
    private readonly IUserProfileRepository _profileRepo;

    public UserProfieController(IUserProfileRepository profileRepo)
    {
        _profileRepo = profileRepo;
    }
    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateUserProfile([FromBody] AddUserProfileDto profileDto)
    {
        var userprofile = _profileRepo.CreateUserProfile(profileDto); 
        return Ok(userprofile);
    }
}