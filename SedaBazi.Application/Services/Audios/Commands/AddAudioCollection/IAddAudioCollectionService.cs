using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Audios.Commands.AddAudioCollection
{
    public interface IAddAudioCollectionService
    {
        ResultDto Execute(AddAudioCollectionRequest request);
    }
}
