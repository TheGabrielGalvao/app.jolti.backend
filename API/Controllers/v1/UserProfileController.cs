using AutoMapper;
using Domain.DTO.Auth;
using Domain.DTO.Common;
using Domain.Interface.Service.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserProfileService _userProfileService;
        private readonly IMapper _mapper;

        public UserProfileController(IUserProfileService userProfileService, IMapper mapper)
        {
            _userProfileService = userProfileService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var userProfiles = await _userProfileService.GetAllAsync();
                return Ok(userProfiles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{uuid}")]
        [Authorize]
        public async Task<IActionResult> Get(Guid uuid)
        {
            try
            {
                var userProfile = await _userProfileService.GetByIdAsync(uuid);
                if (userProfile == null)
                {
                    return NotFound();
                }
                return Ok(userProfile);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create([FromBody] UserProfileRequest userProfile)
        {
            try
            {
                var createdUserProfile = await _userProfileService.AddAsync(userProfile);
                return CreatedAtAction(nameof(Get), new { uuid = createdUserProfile.Uuid }, createdUserProfile);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{uuid}")]
        [Authorize]
        public async Task<IActionResult> Update(Guid uuid, [FromBody] UserProfileRequest userProfile)
        {
            try
            {
                var updatedUserProfile = await _userProfileService.UpdateAsync(uuid, userProfile);
                if (updatedUserProfile == null)
                {
                    return NotFound();
                }
                return Ok(updatedUserProfile);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{uuid}")]
        [Authorize]
        public async Task<IActionResult> Delete(Guid uuid)
        {
            try
            {
                var userProfile = await _userProfileService.GetByIdAsync(uuid);
                if (userProfile == null)
                {
                    return NotFound();
                }

                await _userProfileService.DeleteAsync(uuid);
                return Ok(userProfile);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("option-items")]
        [Authorize]
        public async Task<IEnumerable<OptionItemResponse>> GetUserProfilesToSelectOption()
        {
            return _mapper.Map<List<OptionItemResponse>>(await _userProfileService.GetAllAsync());
        }

    }
}
