namespace SedaBazi.Application.Services.Audios.Commands.DeleteAudioCollection
{
    public class DeleteAudioCollectionRequest
    {
        public long Id { get; }

        public string Owner { get; }

        public DeleteAudioCollectionRequest(long id, string owner)
        {
            Id = id;
            Owner = owner;
        }
    }
}
