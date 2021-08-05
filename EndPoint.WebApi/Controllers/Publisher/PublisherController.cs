using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Publisher.Queries.GetPublisher;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Publisher
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherFacad publisherFacad;

        public PublisherController(IPublisherFacad publisherFacad) =>
            this.publisherFacad = publisherFacad;

        [HttpGet]
        public ActionResult<ResultDto<ResultGetPublisherDto>> Get([FromBody] GetPublisherDto getDto)
        {
            var request = new GetPublisherRequest(getDto.SearchValue);
            return publisherFacad.GetPublisherService.Execute(request);
        }
    }
}
