using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Services.Users.Commands.LoginUser;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Authentications.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public readonly ILoginUserService loginUserService;

        public LoginController(ILoginUserService loginUserService) =>
            this.loginUserService = loginUserService;

        [HttpPost]
        public ActionResult<ResultDto> Register([FromBody] LoginDto loginDto)
        {
            var user = new RequestLoginUserDto
            {
                Email = loginDto.Email,
                Password = loginDto.Password
            };

            return loginUserService.Execute(user);
        }
    }
}
