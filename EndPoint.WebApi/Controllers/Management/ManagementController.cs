using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Managements.Commands.AddManagement;
using SedaBazi.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

    }
}
