using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using System.Linq;

namespace SedaBazi.Application.Services.Managements.Queries.GetManagement
{
    public class GetManagementService : IGetManagementService
    {
        private readonly IDataBaseContext dataBaseContext;

        public GetManagementService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ResultDto<ResultGetManagementDto> Execute(GetManagementRequest request)
        {
            var managements = dataBaseContext.Managements.AsQueryable();

            var getManagementDtos = managements
                .Where(x => x.AudioCollectionId == request.AudioCollectionId)
                .Select(x => new GetManagementDto(x.Id, x.User, x.AudioCollectionId))
                .ToList();

            var result = new ResultGetManagementDto(getManagementDtos);

            return new ResultDto<ResultGetManagementDto>(true, "List returned successfully.", result);
        }
    }
}
