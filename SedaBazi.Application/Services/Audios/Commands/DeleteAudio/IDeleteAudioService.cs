using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Audios.Commands.DeleteAudio
{
    public interface IDeleteAudioService
    {
        ResultDto Execute(DeleteAudioRequest request);
    }
}
