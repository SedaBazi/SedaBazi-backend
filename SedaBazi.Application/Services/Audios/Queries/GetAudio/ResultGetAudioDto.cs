using System.Collections.Generic;

namespace SedaBazi.Application.Services.Audios.Queries.GetAudio
{
    public class ResultGetAudioDto
    {
        public List<GetAudioDto> GetAudioDtos { get; }

        public int RowsCount { get; }

        public ResultGetAudioDto(int rowsCount, List<GetAudioDto> getAudioDtos)
        {
            RowsCount = rowsCount;
            GetAudioDtos = getAudioDtos;
        }
    }
}
