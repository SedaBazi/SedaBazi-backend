using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using System;
using System.Linq;

namespace SedaBazi.Application.Services.Managements.Commands.DeleteManagement
{
    public class DeleteManagementService : IDeleteManagementService
    {
        private readonly IDataBaseContext dataBaseContext;

        public DeleteManagementService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ResultDto Execute(DeleteManagementRequest request)
        {
            var management = dataBaseContext.Managements.FirstOrDefault(x => x.Id == request.Id);

            if (management == null)
            {
                return new ResultDto(true, "Management is not available.");
            }

            var audioCollections = dataBaseContext.AudioCollections.FirstOrDefault(x => x.Id == management.AudioCollectionId);

            if (audioCollections.Owner != request.Owner)
            {
                return new ResultDto(true, "User access is not allowed.");
            }

            management.IsDeleted = true;
            management.DeleteTime = DateTime.Now;

            dataBaseContext.SaveChanges();

            return new ResultDto(true, "Management deleted successfully.");
        }
    }
}
