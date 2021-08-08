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

namespace SedaBazi.Application.Interfaces.FacadPatterns
{
    public interface IAudioFacad
    {
        IAddAudioCollectionService AddAudioCollectionService { get; }

        IDeleteAudioCollectionService DeleteAudioCollectionService { get; }

        IEditAudioCollectionService EditAudioCollectionService { get; }

        IGetAudioCollectionService GetAudioCollectionService { get; }

        IAddAudioService AddAudioService { get; }

        IDeleteAudioService DeleteAudioService { get; }

        IEditAudioService EditAudioService { get; }

        IGetAudioService GetAudioService { get; }

        IAddAudioLinkService AddAudioLinkService { get; }

        IDeleteAudioLinkService DeleteAudioLinkService { get; }
    }
}
