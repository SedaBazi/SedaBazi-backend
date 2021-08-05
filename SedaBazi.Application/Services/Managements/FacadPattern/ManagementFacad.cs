using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Managements.Commands.AddManagement;
using SedaBazi.Application.Services.Managements.Commands.DeleteManagement;
using SedaBazi.Application.Services.Managements.Queries.GetManagement;

namespace SedaBazi.Application.Services.Managements.FacadPattern
{
    public class ManagementFacad : IManagementFacad
    {
        private readonly IDataBaseContext dataBaseContext;

        private IAddManagementService addManagementService;

        private IDeleteManagementService deleteManagementService;

        private IGetManagementService getManagementService;

        public ManagementFacad(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public IAddManagementService AddManagementService
        {
            get
            {
                return addManagementService ??= new AddManagementService(dataBaseContext);
            }
        }

        public IDeleteManagementService DeleteManagementService
        {
            get
            {
                return deleteManagementService ??= new DeleteManagementService(dataBaseContext);
            }
        }

        public IGetManagementService GetManagementService
        {
            get
            {
                return getManagementService ??= new GetManagementService(dataBaseContext);
            }
        }
    }
}
