using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Audios.Commands.AddAudioCollection;

namespace SedaBazi.Application.Services.Audios.FacadPattern
{
    public class AudioFacad : IAudioFacad
    {
        private readonly IDataBaseContext dataBaseContext;
        private AddAudioCollectionService addAudioCollectionService;

        public AudioFacad(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public AddAudioCollectionService AddAudioCollectionService
        {
            get
            {
                return addAudioCollectionService ??= new AddAudioCollectionService(dataBaseContext);
            }
        }
    }
}
