namespace SedaBazi.Application.Services.Audios.Commands.DeleteAudio
{
    public class DeleteAudioRequest
    {
        public long Id { get; }

        public string Owner { get; }

        public DeleteAudioRequest(long id, string owner)
        {
            Id = id;
            Owner = owner;
        }
    }
}
