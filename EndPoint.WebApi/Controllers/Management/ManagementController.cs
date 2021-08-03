using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Managements.Commands.AddManagement;
using SedaBazi.Application.Services.Managements.Commands.DeleteManagement;
using SedaBazi.Application.Services.Managements.Queries.GetManagement;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Management
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagementController : ControllerBase
    {
        private readonly IManagementFacad managementFacad;

        public ManagementController(IManagementFacad managementFacad) =>
            this.managementFacad = managementFacad;

        [HttpPost]
        public ActionResult<ResultDto> Post([FromBody] AddManagementDto addDto)
        {
            var owner = User.Identity.Name;

            if (owner == null)
            {
                return new ResultDto(false, "No user available.");
            }

            var request = new AddManagementRequest(addDto.User, addDto.AudioCollectionId, owner);

            return managementFacad.AddManagementService.Execute(request);
        }

        [HttpDelete]
        public ActionResult<ResultDto> Delete([FromBody] DeleteManagementDto deleteDto)
        {
            var owner = User.Identity.Name;

            if (owner == null)
            {
                return new ResultDto(false, "No user available.");
            }

            var request = new DeleteManagementRequest(deleteDto.Id, owner);

            return managementFacad.DeleteManagementService.Execute(request);
        }

        [HttpGet]
        public ActionResult<ResultDto<ResultGetManagementDto>> Get([FromBody] GetManagementDto getDto)
        {
            var request = new GetManagementRequest(getDto.AudioCollectionId);
            return managementFacad.GetManagementService.Execute(request);
        }
    }
}
