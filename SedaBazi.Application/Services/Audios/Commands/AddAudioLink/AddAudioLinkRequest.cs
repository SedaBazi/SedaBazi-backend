namespace SedaBazi.Application.Services.Audios.Commands.AddAudioLink
{
    public class AddAudioLinkRequest
    {
        public string User { get; }

        public long AudioId { get; }

        public long AudioCollectionId { get; }

        public AddAudioLinkRequest(string user, long audioId, long audioCollectionId)
        {
            User = user;
            AudioId = audioId;
            AudioCollectionId = audioCollectionId;
        }
    }
}
