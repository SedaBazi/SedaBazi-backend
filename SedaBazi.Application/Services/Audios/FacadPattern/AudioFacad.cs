using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Audios.Commands.AddAudio;
using SedaBazi.Application.Services.Audios.Commands.AddAudioCollection;
using SedaBazi.Application.Services.Audios.Commands.AddAudioLink;
using SedaBazi.Application.Services.Audios.Commands.DeleteAudio;
using SedaBazi.Application.Services.Audios.Commands.DeleteAudioCollection;
using SedaBazi.Application.Services.Audios.Commands.DeleteAudioLink;
using SedaBazi.Application.Services.Audios.Commands.EditAudio;
using SedaBazi.Application.Services.Audios.Commands.EditAudioCollection;
using SedaBazi.Application.Services.Audios.Queries.GetAudio;
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

        private IAddAudioService addAudioService;

        private IDeleteAudioService deleteAudioService;

        private IEditAudioService editAudioService;

        private IGetAudioService getAudioService;

        private IAddAudioLinkService addAudioLinkService;

        private IDeleteAudioLinkService deleteAudioLinkService;

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

        public IAddAudioService AddAudioService
        {
            get
            {
                return addAudioService ??= new AddAudioService(dataBaseContext);
            }
        }

        public IDeleteAudioService DeleteAudioService
        {
            get
            {
                return deleteAudioService ??= new DeleteAudioService(dataBaseContext);
            }
        }

        public IEditAudioService EditAudioService
        {
            get
            {
                return editAudioService ??= new EditAudioService(dataBaseContext);
            }
        }

        public IGetAudioService GetAudioService
        {
            get
            {
                return getAudioService ??= new GetAudioService(dataBaseContext);
            }
        }

        public IAddAudioLinkService AddAudioLinkService
        {
            get
            {
                return addAudioLinkService ??= new AddAudioLinkService(dataBaseContext);
            }
        }

        public IDeleteAudioLinkService DeleteAudioLinkService
        {
            get
            {
                return deleteAudioLinkService ??= new DeleteAudioLinkService(dataBaseContext);
            }
        }
    }
}
