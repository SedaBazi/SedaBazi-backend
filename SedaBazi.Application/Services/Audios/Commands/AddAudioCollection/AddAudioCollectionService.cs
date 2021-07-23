using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using SedaBazi.Domain.Entities.Audios;

namespace SedaBazi.Application.Services.Audios.Commands.AddAudioCollection
{
    public class AddAudioCollectionService : IAddAudioCollectionService
    {
        private readonly IDataBaseContext dataBaseContext;

        public AddAudioCollectionService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ResultDto Execute(AddAudioCollectionRequest request)
        {
            var audioCollection = new AudioCollection
            {
                Name = request.Name,
                Description = request.Description,
                Owner = request.Owner,
                ImageUrl = request.ImageUrl,
                Type = request.Type.ToString()
            };

            dataBaseContext.AudioCollections.Add(audioCollection);
            dataBaseContext.SaveChanges();

            return new ResultDto(true, "Audio Collection added successfully.");
        }
    }
}
