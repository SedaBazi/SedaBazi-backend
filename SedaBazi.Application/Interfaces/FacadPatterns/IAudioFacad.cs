using SedaBazi.Application.Services.Audios.Commands.AddAudioCollection;

namespace SedaBazi.Application.Interfaces.FacadPatterns
{
    public interface IAudioFacad
    {
        AddAudioCollectionService AddAudioCollectionService { get; }
    }
}
