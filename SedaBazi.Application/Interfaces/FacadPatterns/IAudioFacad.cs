using SedaBazi.Application.Services.Audios.Commands.AddAudioCollection;
using SedaBazi.Application.Services.Audios.Commands.DeleteAudioCollection;

namespace SedaBazi.Application.Interfaces.FacadPatterns
{
    public interface IAudioFacad
    {
        IAddAudioCollectionService AddAudioCollectionService { get; }
        IDeleteAudioCollectionService DeleteAudioCollectionService { get; }
    }
}
