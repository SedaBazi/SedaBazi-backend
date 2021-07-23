using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Audios.Commands.AddAudioCollection;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Audio.AudioCollection
{
    [Route("api/[controller]")]
    [ApiController]
    public class AudioCollectionController : ControllerBase
    {
        private readonly IAudioFacad audioFacad;

        public AudioCollectionController(IAudioFacad audioFacad) =>
            this.audioFacad = audioFacad;

        [HttpPost]
        public ActionResult<ResultDto> Post([FromBody] AudioCollectionDto audioCollectionDto)
        {
            var owner = User.Identity.Name;

            if (owner == null)
            {
                return new ResultDto(false, "No user available.");
            }

            var request = new AddAudioCollectionRequest
            {
                Name = audioCollectionDto.Name,
                Description = audioCollectionDto.Description,
                Owner = owner,
                ImageUrl = audioCollectionDto.ImageUrl,
                Type = audioCollectionDto.Type
            };

            return audioFacad.AddAudioCollectionService.Execute(request);
        }
    }
}
