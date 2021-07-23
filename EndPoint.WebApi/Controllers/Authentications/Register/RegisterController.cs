using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Services.Users.Commands.Register;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Authentications.Register
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        public readonly IRegisterService registerUserService;

        public RegisterController(IRegisterService registerUserService) =>
            this.registerUserService = registerUserService;

        [HttpPost]
        public ActionResult<ResultDto> Post([FromBody] RegisterDto registerDto)
        {
            var request = new RegisterRequest(registerDto.FirstName,
                registerDto.LastName, registerDto.Email, registerDto.Password);
            return registerUserService.Execute(request);
        }
    }
}
