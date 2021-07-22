using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Services.Users.Commands.RegisterUser;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Authentications.Register
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        public readonly IRegisterUserService registerUserService;

        public RegisterController(IRegisterUserService registerUserService) =>
            this.registerUserService = registerUserService;

        [HttpPost]
        public ActionResult<ResultDto> Register([FromBody] RegisterDto registerDto)
        {
            var user = new RequestRegisterUserDto
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Email = registerDto.Email,
                Password = registerDto.Password
            };

            return registerUserService.Execute(user);
        }
    }
}
