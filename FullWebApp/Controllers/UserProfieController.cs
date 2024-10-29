using FullWebApp.DTOs.UserProfileDTOs;
using FullWebApp.Interfaces;
using FullWebApp.Mappers;
using FullWebApp.Models;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateUserProfile([FromBody] UserProfileDto userProfileDto)
    {
        if (ModelState!.IsValid)
        {
            return BadRequest(ModelState);
        }
        var userprofile = userProfileDto.ToUserProfileFromCreate();
        await _profileRepo.CreateUserProfile(userprofile);
        return Ok(userprofile);
    }
    [Authorize]
    [HttpGet]
    [Route("{id:int}")]
    public  async Task<IActionResult> GetById([FromRoute] int id)
    {
        var userProfile = await _profileRepo.GetUserProfileById(id);
        if (userProfile == null)
        {
            return NotFound();
        }

        return Ok(userProfile.ToDtoFromProfile());
    }
    
    [Authorize]
    [HttpPut]
    [Route("{id:int}")]
    public async Task<IActionResult> UpdateUserProfile([FromRoute] int id, [FromBody] UserProfileDto profileDto)
    {
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
        var model = await _profileRepo.DeleteAsync(id);
        if (model == null)
        {
            return NotFound("Ja ke huq diqka");
        }

        return Ok(model.ToDtoFromProfile());
    }
    
}