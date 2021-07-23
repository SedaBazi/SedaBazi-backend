using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using System;
using System.Linq;

namespace SedaBazi.Application.Services.Audios.Commands.EditAudioCollection
{
    public class EditAudioCollectionService : IEditAudioCollectionService
    {
        private readonly IDataBaseContext dataBaseContext;

        public EditAudioCollectionService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ResultDto Execute(EditAudioCollectionRequest request)
        {
            var audioCollection = dataBaseContext.AudioCollections.FirstOrDefault(x => x.Id == request.Id);

            if (audioCollection == null)
            {
                return new ResultDto(true, "Audio Collection not available.");
            }

            if (audioCollection.Owner != request.Owner)
            {
                return new ResultDto(true, "User access is not allowed.");
            }

            audioCollection.Name = request.Name;
            audioCollection.Description = request.Description;
            audioCollection.ImageUrl = request.ImageUrl;
            audioCollection.Type = request.Type;
            audioCollection.UpdateTime = DateTime.Now;

            dataBaseContext.SaveChanges();

            return new ResultDto(true, "Audio Collection edited successfully.");
        }
    }
}
