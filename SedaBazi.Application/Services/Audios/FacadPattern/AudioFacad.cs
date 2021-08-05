using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Audios.Commands.AddAudioCollection;
using SedaBazi.Application.Services.Audios.Commands.DeleteAudioCollection;
using SedaBazi.Application.Services.Audios.Commands.EditAudioCollection;
using SedaBazi.Application.Services.Audios.Queries.GetAudioCollection;

namespace SedaBazi.Application.Services.Audios.FacadPattern
{
    public class AudioFacad : IAudioFacad
    {
        private readonly IDataBaseContext dataBaseContext;

        private IAddAudioCollectionService addAudioCollectionService;

        private IDeleteAudioCollectionService deleteAudioCollectionService;

        private IEditAudioCollectionService editAudioCollectionService;

        private IGetAudioCollectionService getAudioCollectionService;

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

        public IEditAudioCollectionService EditAudioCollectionService
        {
            get
            {
                return editAudioCollectionService ??= new EditAudioCollectionService(dataBaseContext);
            }
        }

        public IGetAudioCollectionService GetAudioCollectionService
        {
            get
            {
                return getAudioCollectionService ??= new GetAudioCollectionService(dataBaseContext);
            }
        }
    }
}
