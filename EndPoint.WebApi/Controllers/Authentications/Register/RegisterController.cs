using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Users.Commands.Register;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Authentications.Register
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IUserFacad userFacad;

        public RegisterController(IUserFacad userFacad) =>
            this.userFacad = userFacad;

        [HttpPost]
        public ActionResult<ResultDto> Post([FromBody] RegisterDto registerDto)
        {
            var request = new RegisterRequest(registerDto.FirstName, registerDto.LastName,
                registerDto.Email.ToLower(), registerDto.Password, registerDto.IsPublisher);
            return userFacad.RegisterService.Execute(request);
        }
    }
}
