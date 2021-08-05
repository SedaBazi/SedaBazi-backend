using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using System.Linq;

namespace SedaBazi.Application.Services.Publisher.Queries.GetPublisher
{
    public class GetPublisherService : IGetPublisherService
    {
        private readonly IDataBaseContext dataBaseContext;

        public GetPublisherService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ResultDto<ResultGetPublisherDto> Execute(GetPublisherRequest request)
        {
            var publisher = dataBaseContext.Users.AsQueryable();

            var getPublisherDtos = publisher
                .Where(x => x.IsPublisher && (
                    string.IsNullOrEmpty(request.SearchValue) ||
                    x.FirstName.ToLower().Contains(request.SearchValue) || 
                    x.LastName.ToLower().Contains(request.SearchValue) || 
                    x.Email.ToLower().Contains(request.SearchValue)))
                .Select(x => new GetPublisherDto(x.FirstName, x.LastName, x.Email))
                .ToList();

            var result = new ResultGetPublisherDto(getPublisherDtos);

            return new ResultDto<ResultGetPublisherDto>(true, "List returned successfully.", result);
        }
    }
}
