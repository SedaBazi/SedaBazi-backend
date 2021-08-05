using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Managements.Commands.AddManagement
{
    public interface IAddManagementService
    {
        ResultDto Execute(AddManagementRequest request);
    }
}
