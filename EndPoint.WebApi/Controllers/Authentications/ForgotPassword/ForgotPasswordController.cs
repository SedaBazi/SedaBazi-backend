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
            var request = new ForgotPasswordRequest(forgotPasswordDto.Email);
            return userFacad.ForgotPasswordService.Execute(request);
        }
    }
}
