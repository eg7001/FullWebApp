using FullWebApp.DTOs.UserProfileDTOs;
using FullWebApp.Extensions;
using FullWebApp.Interfaces;
using FullWebApp.Mappers;
using FullWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FullWebApp.Controllers;
[Route("api/userProfileController")]
[ApiController]
public class UserProfieController: ControllerBase
{
    private readonly IUserProfileRepository _profileRepo;
    private readonly UserManager<AppUser> _userManager; 
    public UserProfieController(IUserProfileRepository profileRepo, UserManager<AppUser> userManager)
    {
        _profileRepo = profileRepo;
        _userManager = userManager;
    }
    [Authorize]
    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateUserProfile([FromBody] UserProfileDto userProfileDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var username = User.GetUsername();
        var appUser= await _userManager.FindByNameAsync(username);
        var userprofile = userProfileDto.ToUserProfileFromCreate(appUser.Id);
        await _profileRepo.CreateUserProfile(userprofile);
        return Ok(userprofile);
    }
    [Authorize]
    [HttpGet]
    [Route("{id:int}")]
    public  async Task<IActionResult> GetById([FromRoute] int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var userProfile = await _profileRepo.GetUserProfileById(id);
        if (userProfile == null)
        {
            return NotFound();
        }
        return Ok(userProfile.ToDtoFromProfile());
    }
    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetByUser(){
        if(!ModelState.IsValid){
            return BadRequest(ModelState);
        }
        var userName = User.GetUsername();
        var appUser = await _userManager.FindByNameAsync(userName);

        var userProfile = await _profileRepo.GetByUser(appUser.Id);
        return Ok(userProfile);
    }

    [Authorize]
    [HttpPut]
    [Route("{id:int}")]
    public async Task<IActionResult> UpdateUserProfile([FromRoute] int id, [FromBody] UserProfileDto profileDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var userProfileModel =await _profileRepo.UpdateUserProfile(id, profileDto);
        if (userProfileModel == null)
        {
            return NotFound("Su gjet vllaqko");
        }
        return Ok(userProfileModel.ToDtoFromProfile());
    }
    [Authorize]
    [HttpDelete]
    [Route("remove/{id:int}")]
    public async Task<IActionResult> DeleteProfile([FromRoute] int id)
    {
       if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var model = await _profileRepo.DeleteAsync(id);
        if (model == null)
        {
            return NotFound("Ja ke huq diqka");
        }
        return Ok(model.ToDtoFromProfile());
    }
} 