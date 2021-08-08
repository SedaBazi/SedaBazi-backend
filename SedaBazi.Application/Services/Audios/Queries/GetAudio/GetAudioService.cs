using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using SedaBazi.Common.Util;
using System.Collections.Generic;
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
            var linkIdByAudioId = new Dictionary<long, long>();

            if (request.AudioCollectionId != null)
            {
                linkIdByAudioId = dataBaseContext.AudioLinks
                    .Where(x => x.AudioCollectionId == request.AudioCollectionId)
                    .ToDictionary(x => x.AudioId, x => x.Id);
                var audioIds = linkIdByAudioId.Keys.ToList();
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
                .Where(x => string.IsNullOrEmpty(request.SearchValue) ||
                    x.Name.ToLower().Contains(request.SearchValue) ||
                    x.Description.ToLower().Contains(request.SearchValue) ||
                    x.Owner.ToLower().Contains(request.SearchValue))
                .ToPaged(request.Page, request.Size, out var rowsCount)
                .Select(x => new GetAudioDto(x.Id, x.Owner, x.Name, x.Description,
                    x.ImageUrl, x.IsPremium, x.FileUrl128, x.FileUrl320))
                .ToList();

            foreach (var getAudioDto in getAudioDtos)
            {
                getAudioDto.LinkId = linkIdByAudioId.GetValueOrDefault(getAudioDto.Id);
            }

            var result = new ResultGetAudioDto(rowsCount, getAudioDtos);

            return new ResultDto<ResultGetAudioDto>(true, "List returned successfully.", result);
        }
    }
}
