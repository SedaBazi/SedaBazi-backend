using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using SedaBazi.Domain.Entities.Audios;
using System.Linq;

namespace SedaBazi.Application.Services.Audios.Commands.AddAudio
{
    public class AddAudioService : IAddAudioService
    {
        private readonly IDataBaseContext dataBaseContext;

        public AddAudioService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ResultDto Execute(AddAudioRequest request)
        {
            if (!dataBaseContext.Users.First(x => x.UserName == request.Owner).IsPublisher)
            {
                return new ResultDto(false, "User is not a publisher.");
            }

            var audio = new Audio
            {
                Name = request.Name,
                Description = request.Description,
                Owner = request.Owner,
                ImageUrl = request.ImageUrl,
                IsPremium = request.IsPremium,
                FileUrl128 = request.FileUrl128,
                FileUrl320 = request.FileUrl320
            };

            dataBaseContext.Audios.Add(audio);
            dataBaseContext.SaveChanges();

            return new ResultDto(true, "Audio added successfully.");
        }
    }
}
