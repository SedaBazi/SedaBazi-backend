using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Audios.Queries.GetAudioCollection
{
    public interface IGetAudioCollectionService
    {
        ResultDto<ReslutGetAudioCollectionDto> Execute(GetAudioCollectionRequest request);
    }
}
