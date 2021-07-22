using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Services.Users.Commands.ForgotPassword;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Authentications.ForgotPassword
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForgotPasswordController : ControllerBase
    {
        public readonly IForgotPasswordService forgotPasswordService;

        public ForgotPasswordController(IForgotPasswordService forgotPasswordService) =>
            this.forgotPasswordService = forgotPasswordService;

        [HttpPost]
        public ActionResult<ResultDto> ForgotPassword([FromBody] ForgotPasswordDto forgotPasswordDto)
        {
            var user = new RequestForgotPasswordDto
            {
                Email = forgotPasswordDto.Email
            };

            return forgotPasswordService.Execute(user);
        }
    }
}
