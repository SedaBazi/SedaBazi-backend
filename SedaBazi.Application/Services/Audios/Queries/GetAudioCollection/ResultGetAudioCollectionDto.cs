using System.Collections.Generic;

namespace SedaBazi.Application.Services.Audios.Queries.GetAudioCollection
{
    public class ResultGetAudioCollectionDto
    {
        public List<GetAudioCollectionDto> GetAudioCollectionDtos { get; }

        public int RowsCount { get; }

        public ResultGetAudioCollectionDto(int rowsCount, List<GetAudioCollectionDto> getAudioCollectionDtos)
        {
            RowsCount = rowsCount;
            GetAudioCollectionDtos = getAudioCollectionDtos;
        }
    }
}
