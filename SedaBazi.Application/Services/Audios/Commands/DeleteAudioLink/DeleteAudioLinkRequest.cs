namespace SedaBazi.Application.Services.Audios.Commands.DeleteAudioLink
{
    public class DeleteAudioLinkRequest
    {
        public long Id { get; }

        public string User { get; }

        public DeleteAudioLinkRequest(long id, string user)
        {
            Id = id;
            User = user;
        }
    }
}
