using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Audios.Commands.AddAudioLink
{
    public interface IAddAudioLinkService
    {
        ResultDto Execute(AddAudioLinkRequest request);
    }
}
