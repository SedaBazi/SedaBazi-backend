using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Audios.Commands.AddAudioCollection;
using SedaBazi.Application.Services.Audios.Commands.DeleteAudioCollection;

namespace SedaBazi.Application.Services.Audios.FacadPattern
{
    public class AudioFacad : IAudioFacad
    {
        private readonly IDataBaseContext dataBaseContext;

        private IAddAudioCollectionService addAudioCollectionService;
        private IDeleteAudioCollectionService deleteAudioCollectionService;

        public AudioFacad(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public IAddAudioCollectionService AddAudioCollectionService
        {
            get
            {
                return addAudioCollectionService ??= new AddAudioCollectionService(dataBaseContext);
            }
        }

        public IDeleteAudioCollectionService DeleteAudioCollectionService
        {
            get
            {
                return deleteAudioCollectionService ??= new DeleteAudioCollectionService(dataBaseContext);
            }
        }
    }
}
