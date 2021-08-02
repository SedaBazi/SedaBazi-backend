using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using SedaBazi.Domain.Entities.Managements;
using System.Linq;

namespace SedaBazi.Application.Services.Managements.Commands.AddManagement
{
    public class AddManagementService : IAddManagementService
    {
        private readonly IDataBaseContext dataBaseContext;

        public AddManagementService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ResultDto Execute(AddManagementRequest request)
        {
            var audioCollection = dataBaseContext.AudioCollections.FirstOrDefault(x => x.Id == request.AudioCollectionId);

            if (audioCollection == null)
            {
                return new ResultDto(true, "Audio Collection is not available.");
            }

            if (dataBaseContext.Users.All(x => x.UserName != request.User))
            {
                return new ResultDto(true, "User is not available.");
            }

            if (audioCollection.Owner != request.Owner)
            {
                return new ResultDto(true, "User access is not allowed.");
            }

            var management = new Management
            {
                User = request.User,
                AudioCollectionId = request.AudioCollectionId
            };

            dataBaseContext.Managements.Add(management);
            dataBaseContext.SaveChanges();

            return new ResultDto(true, "Management added successfully.");
        }
    }
}
