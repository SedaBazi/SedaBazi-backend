using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Services.Users.Commands.Logout;

namespace EndPoint.WebApi.Controllers.Authentications.Logout
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogoutController : ControllerBase
    {
        public readonly ILogoutService logoutUserService;

        public LogoutController(ILogoutService logoutUserService) =>
            this.logoutUserService = logoutUserService;

        [HttpPost]
        public void Post() => logoutUserService.Execute();
    }
}
