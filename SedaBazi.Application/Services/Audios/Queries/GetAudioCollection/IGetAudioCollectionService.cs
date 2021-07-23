using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Audios.Queries.GetAudioCollection
{
    public interface IGetAudioCollectionService
    {
        ReslutGetAudioCollectionDto Execute(GetAudioCollectionRequest request);
    }
}
