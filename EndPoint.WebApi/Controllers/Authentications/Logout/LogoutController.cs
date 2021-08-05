using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Authentications.Logout
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogoutController : ControllerBase
    {
        private readonly IUserFacad userFacad;

        public LogoutController(IUserFacad userFacad) =>
            this.userFacad = userFacad;

        [HttpPost]
        public ActionResult<ResultDto> Post() =>
            userFacad.LogoutService.Execute();
    }
}
