using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using SedaBazi.Domain.Entities.Audios;
using System.Linq;

namespace SedaBazi.Application.Services.Audios.Commands.AddAudioLink
{
    public class AddAudioLinkService
    {
        private readonly IDataBaseContext dataBaseContext;

        public AddAudioLinkService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ResultDto Execute(AddAudioLinkRequest request)
        {
            var audioCollection = dataBaseContext.AudioCollections.FirstOrDefault(x => x.Id == request.AudioCollectionId);

            if (audioCollection == null)
            {
                return new ResultDto(false, "Audio Collection is not available.");
            }

            if (dataBaseContext.Audios.All(x => x.Id != request.AudioId))
            {
                return new ResultDto(false, "Audio is not available.");
            }

            if (dataBaseContext.Managements.All(x => x.AudioCollectionId != request.AudioCollectionId ||
                x.User != request.User) && request.User != audioCollection.Owner)
            {
                return new ResultDto(false, "User access is not allowed.");
            }

            if (dataBaseContext.AudioLinks.Any(x => x.AudioCollectionId == request.AudioCollectionId && x.AudioId == request.AudioId))
            {
                return new ResultDto(false, "Audio is available");
            }

            var audioLink = new AudioLink
            {
                User = request.User,
                AudioId = request.AudioId,
                AudioCollectionId = request.AudioCollectionId
            };

            dataBaseContext.AudioLinks.Add(audioLink);
            dataBaseContext.SaveChanges();

            return new ResultDto(true, "Audio added successfully.");
        }
    }
}
