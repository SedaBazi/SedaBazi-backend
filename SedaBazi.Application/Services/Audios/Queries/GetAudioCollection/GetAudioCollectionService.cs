using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using SedaBazi.Common.Util;
using System.Linq;

namespace SedaBazi.Application.Services.Audios.Queries.GetAudioCollection
{
    public class GetAudioCollectionService : IGetAudioCollectionService
    {
        private readonly IDataBaseContext dataBaseContext;

        public GetAudioCollectionService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ResultDto<ReslutGetAudioCollectionDto> Execute(GetAudioCollectionRequest request)
        {
            var audioCollections = dataBaseContext.AudioCollections.AsQueryable();

            var getAudioCollectionDtos = audioCollections
                .ToPaged(request.Page, request.Size, out var rowsCount)
                .Select(x => new GetAudioCollectionDto(x.Id, x.Owner, x.Name, x.Description, x.ImageUrl, x.Type))
                .ToList();

            var result = new ReslutGetAudioCollectionDto(rowsCount, getAudioCollectionDtos);

            return new ResultDto<ReslutGetAudioCollectionDto>(true, "List returned successfully.", result);
        }
    }
}
