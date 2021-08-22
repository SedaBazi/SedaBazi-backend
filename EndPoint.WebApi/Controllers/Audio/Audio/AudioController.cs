using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Audios.Commands.AddAudio;
using SedaBazi.Application.Services.Audios.Commands.DeleteAudio;
using SedaBazi.Application.Services.Audios.Commands.EditAudio;
using SedaBazi.Application.Services.Audios.Queries.GetAudio;
using SedaBazi.Common.Dto;

namespace EndPoint.WebApi.Controllers.Audio.Audio
{
    [Route("api/[controller]")]
    [ApiController]
    public class AudioController : ControllerBase
    {
        private readonly IAudioFacad audioFacad;

        public AudioController(IAudioFacad audioFacad) =>
            this.audioFacad = audioFacad;

        [HttpPost]
        public ActionResult<ResultDto> Post([FromBody] AddAudioDto addDto)
        {
            var owner = User.Identity.Name;

            if (owner == null)
            {
                return new ResultDto(false, "No user available.");
            }

            var request = new AddAudioRequest(addDto.Name, addDto.Description, owner,
                addDto.ImageUrl, addDto.IsPremium, addDto.FileUrl128, addDto.FileUrl320);

            return audioFacad.AddAudioService.Execute(request);
        }

        [HttpDelete]
        public ActionResult<ResultDto> Delete([FromBody] DeleteAudioDto deleteDto)
        {
            var owner = User.Identity.Name;

            if (owner == null)
            {
                return new ResultDto(false, "No user available.");
            }

            var request = new DeleteAudioRequest(deleteDto.Id, owner);

            return audioFacad.DeleteAudioService.Execute(request);
        }

        [HttpPut]
        public ActionResult<ResultDto> Put([FromBody] EditAudioDto editDto)
        {
            var owner = User.Identity.Name;

            if (owner == null)
            {
                return new ResultDto(false, "No user available.");
            }

            var request = new EditAudioRequest(editDto.Id, owner, editDto.Name, editDto.Description,
                editDto.ImageUrl, editDto.IsPremium, editDto.FileUrl128, editDto.FileUrl320);

            return audioFacad.EditAudioService.Execute(request);
        }

        [HttpGet]
        public ActionResult<ResultDto<ResultGetAudioDto>> Get([FromBody] GetAudioDto getDto)
        {
            var request = new GetAudioRequest(getDto.Page, getDto.Size, getDto.SearchValue, getDto.AudioCollectionId);
            return audioFacad.GetAudioService.Execute(request);
        }
    }
}
