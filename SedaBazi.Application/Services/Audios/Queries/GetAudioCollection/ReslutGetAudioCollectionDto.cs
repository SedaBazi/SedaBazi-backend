using System.Collections.Generic;

namespace SedaBazi.Application.Services.Audios.Queries.GetAudioCollection
{
    public class ReslutGetAudioCollectionDto
    {
        public List<GetAudioCollectionDto> GetAudioCollectionDtos { get; }
        
        public int RowsCount { get; }

        public ReslutGetAudioCollectionDto(int rowsCount, List<GetAudioCollectionDto> getAudioCollectionDtos)
        {
            RowsCount = rowsCount;
            GetAudioCollectionDtos = getAudioCollectionDtos;
        }
    }
}
