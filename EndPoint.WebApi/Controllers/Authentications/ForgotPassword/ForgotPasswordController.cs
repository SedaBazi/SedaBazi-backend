using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Users.Commands.ForgotPassword;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Authentications.ForgotPassword
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForgotPasswordController : ControllerBase
    {
        private readonly IUserFacad userFacad;

        public ForgotPasswordController(IUserFacad userFacad) =>
            this.userFacad = userFacad;

        [HttpPost]
        public ActionResult<ResultDto> Post([FromBody] ForgotPasswordDto forgotPasswordDto)
        {
            if (forgotPasswordDto.SendByEmail && string.IsNullOrEmpty(forgotPasswordDto.Email))
            {
                return new ResultDto(false, "The Email field is required.");
            }

            if (!forgotPasswordDto.SendByEmail && string.IsNullOrEmpty(forgotPasswordDto.PhoneNumber))
            {
                return new ResultDto(false, "The Phone field is required.");
            }

            var request = new ForgotPasswordRequest(forgotPasswordDto.Email, 
                forgotPasswordDto.PhoneNumber, forgotPasswordDto.SendByEmail);
            return userFacad.ForgotPasswordService.Execute(request);
        }
    }
}
