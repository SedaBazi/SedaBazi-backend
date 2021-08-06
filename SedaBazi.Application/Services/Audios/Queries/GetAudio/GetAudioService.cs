using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using SedaBazi.Common.Util;
using System.Linq;

namespace SedaBazi.Application.Services.Audios.Queries.GetAudio
{
    public class GetAudioService : IGetAudioService
    {
        private readonly IDataBaseContext dataBaseContext;

        public GetAudioService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ResultDto<ResultGetAudioDto> Execute(GetAudioRequest request)
        {
            var audios = dataBaseContext.Audios.AsQueryable();

            if (request.AudioCollectionId != null)
            {
                var audioIds = dataBaseContext.AudioLinks
                    .Where(x => x.AudioCollectionId == request.AudioCollectionId)
                    .Select(x => x.AudioId)
                    .ToList();
                audios = audios.Where(x => audioIds.Contains(x.Id));
            }

            if (!string.IsNullOrEmpty(request.SearchValue))
            {
                audios = audios.Where(x =>
                    x.Name.ToLower().Contains(request.SearchValue) ||
                    x.Description.ToLower().Contains(request.SearchValue) ||
                    x.Owner.ToLower().Contains(request.SearchValue));
            }

            var getAudioDtos = audios
                .ToPaged(request.Page, request.Size, out var rowsCount)
                .Select(x => new GetAudioDto(x.Id, x.Owner, x.Name, x.Description,
                    x.ImageUrl, x.IsPremium, x.FileUrl128, x.FileUrl320))
                .ToList();

            var result = new ResultGetAudioDto(rowsCount, getAudioDtos);

            return new ResultDto<ResultGetAudioDto>(true, "List returned successfully.", result);
        }
    }
}
