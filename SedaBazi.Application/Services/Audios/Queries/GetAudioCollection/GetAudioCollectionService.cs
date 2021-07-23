using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Util;
using System.Linq;

namespace SedaBazi.Application.Services.Audios.Queries.GetAudioCollection
{
    public class GetAudioCollectionService : IGetAudioCollectionService
    {
        private readonly IDataBaseContext dataBaseContext;

        public GetAudioCollectionService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ReslutGetAudioCollectionDto Execute(GetAudioCollectionRequest request)
        {
            var audioCollections = dataBaseContext.AudioCollections.AsQueryable();

            var getAudioCollectionDtos = audioCollections
                .ToPaged(request.Page, request.Size, out var rowsCount)
                .Select(x => new GetAudioCollectionDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Owner = x.Owner,
                    ImageUrl = x.ImageUrl,
                    Type = x.Type
                })
                .ToList();

            return new ReslutGetAudioCollectionDto(rowsCount, getAudioCollectionDtos);
        }
    }
}
