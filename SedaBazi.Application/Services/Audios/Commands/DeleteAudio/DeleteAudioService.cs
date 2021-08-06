using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Common.Dto;
using System;
using System.Linq;

namespace SedaBazi.Application.Services.Audios.Commands.DeleteAudio
{
    public class DeleteAudioService : IDeleteAudioService
    {
        private readonly IDataBaseContext dataBaseContext;

        public DeleteAudioService(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public ResultDto Execute(DeleteAudioRequest request)
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

            audio.IsDeleted = true;
            audio.DeleteTime = DateTime.Now;

            dataBaseContext.SaveChanges();

            return new ResultDto(true, "Audio deleted successfully.");
        }
    }
}
