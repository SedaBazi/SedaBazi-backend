using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Audios.Commands.DeleteAudioLink
{
    public interface IDeleteAudioLinkService
    {
        ResultDto Execute(DeleteAudioLinkRequest request);
    }
}
