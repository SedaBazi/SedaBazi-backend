using SedaBazi.Application.Services.Audios.Commands.AddAudioCollection;
using SedaBazi.Application.Services.Audios.Commands.DeleteAudioCollection;
using SedaBazi.Application.Services.Audios.Commands.EditAudioCollection;
using SedaBazi.Application.Services.Audios.Queries.GetAudioCollection;

namespace SedaBazi.Application.Interfaces.FacadPatterns
{
    public interface IAudioFacad
    {
        IAddAudioCollectionService AddAudioCollectionService { get; }
        IDeleteAudioCollectionService DeleteAudioCollectionService { get; }
        IEditAudioCollectionService EditAudioCollectionService { get; }
        IGetAudioCollectionService GetAudioCollectionService { get; }
    }
}
