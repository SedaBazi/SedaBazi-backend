using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Managements.Commands.DeleteManagement
{
    public interface IDeleteManagementService
    {
        ResultDto Execute(DeleteManagementRequest request);
    }
}
