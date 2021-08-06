using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Audios.Commands.EditAudio
{
    public interface IEditAudioService
    {
        ResultDto Execute(EditAudioRequest request);
    }
}
