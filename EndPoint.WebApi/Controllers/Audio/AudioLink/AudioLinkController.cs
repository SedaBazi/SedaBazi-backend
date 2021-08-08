using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Audios.Commands.AddAudioLink;
using SedaBazi.Application.Services.Audios.Commands.DeleteAudioLink;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Audio.AudioLink
{
    [Route("api/[controller]")]
    [ApiController]
    public class AudioLinkController : ControllerBase
    {
        private readonly IAudioFacad audioFacad;

        public AudioLinkController(IAudioFacad audioFacad) =>
            this.audioFacad = audioFacad;

        [HttpPost]
        public ActionResult<ResultDto> Post([FromBody] AddAudioLinkDto addDto)
        {
            var owner = User.Identity.Name;

            if (owner == null)
            {
                return new ResultDto(false, "No user available.");
            }

            var request = new AddAudioLinkRequest(owner, addDto.AudioCollectionId, addDto.AudioCollectionId);

            return audioFacad.AddAudioLinkService.Execute(request);
        }

        [HttpDelete]
        public ActionResult<ResultDto> Delete([FromBody] DeleteAudioLinkDto deleteDto)
        {
            var owner = User.Identity.Name;

            if (owner == null)
            {
                return new ResultDto(false, "No user available.");
            }

            var request = new DeleteAudioLinkRequest(deleteDto.Id, owner);

            return audioFacad.DeleteAudioLinkService.Execute(request);
        }
    }
}
