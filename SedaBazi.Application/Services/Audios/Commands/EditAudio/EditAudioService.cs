using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using System;
using System.Linq;

namespace SedaBazi.Application.Services.Audios.Commands.EditAudio
{
    public class EditAudioService : IEditAudioService
    {
        private readonly IDataBaseContext dataBaseContext;

        public EditAudioService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ResultDto Execute(EditAudioRequest request)
        {
            var audio = dataBaseContext.Audios.FirstOrDefault(x => x.Id == request.Id);

            if (audio == null)
            {
                return new ResultDto(false, "Audio is not available.");
            }

            if (audio.Owner != request.Owner)
            {
                return new ResultDto(false, "User access is not allowed.");
            }

            audio.Name = request.Name;
            audio.Description = request.Description;
            audio.ImageUrl = request.ImageUrl;
            audio.IsPremium = request.IsPremium;
            audio.FileUrl128 = request.FileUrl128;
            audio.FileUrl320 = request.FileUrl320;
            audio.UpdateTime = DateTime.Now;

            dataBaseContext.SaveChanges();

            return new ResultDto(true, "Audio edited successfully.");
        }
    }
}
