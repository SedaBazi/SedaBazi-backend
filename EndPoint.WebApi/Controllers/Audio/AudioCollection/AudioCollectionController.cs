using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Audios.Commands.AddAudioCollection;
using SedaBazi.Application.Services.Audios.Commands.DeleteAudioCollection;
using SedaBazi.Application.Services.Audios.Commands.EditAudioCollection;
using SedaBazi.Application.Services.Audios.Queries.GetAudioCollection;
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
        public ActionResult<ResultDto> Post([FromBody] AddAudioCollectionDto addDto)
        {
            var owner = User.Identity.Name;

            if (owner == null)
            {
                return new ResultDto(false, "No user available.");
            }

            var request = new AddAudioCollectionRequest(addDto.Name, 
                addDto.Description, owner, addDto.ImageUrl, addDto.Type);

            return audioFacad.AddAudioCollectionService.Execute(request);
        }

        [HttpDelete]
        public ActionResult<ResultDto> Delete([FromBody] DeleteAudioCollectionDto deleteDto)
        {
            var owner = User.Identity.Name;

            if (owner == null)
            {
                return new ResultDto(false, "No user available.");
            }

            var request = new DeleteAudioCollectionRequest(deleteDto.Id, owner);

            return audioFacad.DeleteAudioCollectionService.Execute(request);
        }

        [HttpPut]
        public ActionResult<ResultDto> Put([FromBody] EditAudioCollectionDto editDto)
        {
            var owner = User.Identity.Name;

            if (owner == null)
            {
                return new ResultDto(false, "No user available.");
            }

            var request = new EditAudioCollectionRequest(editDto.Id, owner, editDto.Name, 
                editDto.Description, editDto.ImageUrl, editDto.Type);

            return audioFacad.EditAudioCollectionService.Execute(request);
        }

        [HttpGet]
        public ActionResult<ResultDto<ResultGetAudioCollectionDto>> Get([FromBody] GetAudioCollectionDto getDto)
        {
            var request = new GetAudioCollectionRequest(getDto.Page, getDto.Size);
            return audioFacad.GetAudioCollectionService.Execute(request);
        }
    }
}
