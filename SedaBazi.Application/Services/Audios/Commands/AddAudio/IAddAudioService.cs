using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Audios.Commands.AddAudio
{
    public interface IAddAudioService
    {
        ResultDto Execute(AddAudioRequest request);
    }
}
