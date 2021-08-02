using SedaBazi.Application.Services.Managements.Commands.AddManagement;
using SedaBazi.Application.Services.Managements.Commands.DeleteManagement;
using SedaBazi.Application.Services.Managements.Queries.GetManagement;

namespace SedaBazi.Application.Interfaces.FacadPatterns
{
    public interface IManagementFacad
    {
        IAddManagementService AddManagementService { get; }

        IDeleteManagementService DeleteManagementService { get; }
        
        IGetManagementService GetManagementService { get; }
    }
}
