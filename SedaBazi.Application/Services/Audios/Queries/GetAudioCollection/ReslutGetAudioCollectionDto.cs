using System.Collections.Generic;

namespace SedaBazi.Application.Services.Audios.Queries.GetAudioCollection
{
    public class ReslutGetAudioCollectionDto
    {
        public List<GetAudioCollectionDto> GetAudioCollectionDtos { get; set; }
        
        public int RowsCount { get; set; }

        public ReslutGetAudioCollectionDto(int rowsCount, List<GetAudioCollectionDto> getAudioCollectionDtos)
        {
            RowsCount = rowsCount;
            GetAudioCollectionDtos = getAudioCollectionDtos;
        }
    }
}
