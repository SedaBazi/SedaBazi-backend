using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Audios.Queries.GetAudio
{
    public interface IGetAudioService
    {
        ResultDto<ResultGetAudioDto> Execute(GetAudioRequest request);
    }
}
