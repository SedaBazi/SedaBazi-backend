using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Audios.Commands.DeleteAudioCollection
{
    public interface IDeleteAudioCollectionService
    {
        ResultDto Execute(DeleteAudioCollectionRequest request);
    }
}
