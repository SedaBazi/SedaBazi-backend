using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Services.Users.Commands.LogoutUser;

namespace EndPoint.WebApi.Controllers.Authentications.Logout
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogoutController : ControllerBase
    {
        public readonly ILogoutUserService logoutUserService;

        public LogoutController(ILogoutUserService logoutUserService) =>
            this.logoutUserService = logoutUserService;

        [HttpPost]
        public void Logout() =>
            logoutUserService.Execute();
    }
}
