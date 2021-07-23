using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Audios.Commands.EditAudioCollection
{
    public interface IEditAudioCollectionService
    {
        ResultDto Execute(EditAudioCollectionRequest request);
    }
}
