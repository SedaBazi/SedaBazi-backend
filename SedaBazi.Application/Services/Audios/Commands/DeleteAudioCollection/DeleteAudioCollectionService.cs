using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using System;
using System.Linq;

namespace SedaBazi.Application.Services.Audios.Commands.DeleteAudioCollection
{
    public class DeleteAudioCollectionService : IDeleteAudioCollectionService
    {
        private readonly IDataBaseContext dataBaseContext;

        public DeleteAudioCollectionService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ResultDto Execute(DeleteAudioCollectionRequest request)
        {
            var audioCollection = dataBaseContext.AudioCollections.FirstOrDefault(x => x.Id == request.Id);

            if (audioCollection == null)
            {
                return new ResultDto(false, "Audio Collection is not available.");
            }

            if (audioCollection.Owner != request.Owner)
            {
                return new ResultDto(false, "User access is not allowed.");
            }

            audioCollection.IsDeleted = true;
            audioCollection.DeleteTime = DateTime.Now;

            dataBaseContext.SaveChanges();

            return new ResultDto(true, "Audio Collection deleted successfully.");
        }
    }
}
