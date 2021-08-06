using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using System;
using System.Linq;

namespace SedaBazi.Application.Services.Audios.Commands.DeleteAudioLink
{
    public class DeleteAudioLinkService : IDeleteAudioLinkService
    {
        private readonly IDataBaseContext dataBaseContext;

        public DeleteAudioLinkService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ResultDto Execute(DeleteAudioLinkRequest request)
        {
            var audioLink = dataBaseContext.AudioLinks.FirstOrDefault(x => x.Id == request.Id);

            if (audioLink == null)
            {
                return new ResultDto(false, "Audio is not available.");
            }

            var audioCollection = dataBaseContext.AudioCollections.FirstOrDefault(x => x.Id == audioLink.AudioCollectionId);

            if (audioCollection == null)
            {
                return new ResultDto(false, "Audio collection is not available.");
            }

            if (dataBaseContext.Managements.All(x => x.AudioCollectionId != audioLink.AudioCollectionId ||
                x.User != request.User) && request.User != audioCollection.Owner)
            {
                return new ResultDto(false, "User access is not allowed.");
            }

            audioLink.IsDeleted = true;
            audioLink.DeleteTime = DateTime.Now;

            dataBaseContext.SaveChanges();

            return new ResultDto(true, "Audio deleted successfully.");
        }
    }
}
