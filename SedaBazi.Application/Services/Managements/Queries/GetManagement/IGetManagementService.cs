using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Managements.Queries.GetManagement
{
    public interface IGetManagementService
    {
        ResultDto<ResultGetManagementDto> Execute(GetManagementRequest request);
    }
}
