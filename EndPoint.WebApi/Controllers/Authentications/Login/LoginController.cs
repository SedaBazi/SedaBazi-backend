using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Services.Users.Commands.Login;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Authentications.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public readonly ILoginService loginUserService;

        public LoginController(ILoginService loginUserService) =>
            this.loginUserService = loginUserService;

        [HttpPost]
        public ActionResult<ResultDto> Post([FromBody] LoginDto loginDto)
        {
            var request = new LoginRequest(loginDto.Email, loginDto.Password, loginDto.IsPersistent);
            return loginUserService.Execute(request);
        }
    }
}
