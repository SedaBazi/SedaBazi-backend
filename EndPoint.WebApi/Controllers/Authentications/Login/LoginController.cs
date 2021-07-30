using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Users.Commands.Login;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Authentications.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserFacad userFacad;

        public LoginController(IUserFacad userFacad) =>
            this.userFacad = userFacad;

        [HttpPost]
        public ActionResult<ResultDto> Post([FromBody] LoginDto loginDto)
        {
            var request = new LoginRequest(loginDto.Email, loginDto.Password, loginDto.IsPersistent);
            return userFacad.LoginService.Execute(request);
        }
    }
}
