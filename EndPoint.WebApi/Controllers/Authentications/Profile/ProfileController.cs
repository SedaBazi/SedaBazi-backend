using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Users.Commands.EditProfile;
using SedaBazi.Application.Services.Users.Queries.GetProfile;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Authentications.Profile
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IUserFacad userFacad;

        public ProfileController(IUserFacad userFacad) =>
            this.userFacad = userFacad;

        [HttpPut]
        public ActionResult<ResultDto> Put([FromBody] EditProfileDto editDto)
        {
            var owner = User.Identity.Name;

            if (owner == null)
            {
                return new ResultDto(false, "No user available.");
            }

            var request = new EditProfileRequest(editDto.FirstName, editDto.LastName, owner);

            return userFacad.EditProfileService.Execute(request);
        }

        [HttpGet]
        public ActionResult<ResultDto<GetProfileDto>> Get()
        {
            var owner = User.Identity.Name;

            if (owner == null)
            {
                return new ResultDto<GetProfileDto>(false, "No user available.", null);
            }

            var request = new GetProfileRequest(owner);
            return userFacad.GetProfileService.Execute(request);
        }
    }
}
