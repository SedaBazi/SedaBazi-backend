namespace SedaBazi.Application.Services.Audios.Queries.GetAudio
{
    public class GetAudioRequest
    {
        public int Page { get; }

        public int Size { get; }

        public string SearchValue { get; }

        public long? AudioCollectionId { get; }

        public string Owner { get; }

        public GetAudioRequest(string owner, int page, int size, string searchValue, long? audioCollectionId)
        {
            Owner = owner;
            Page = page;
            Size = size;
            SearchValue = searchValue;
            AudioCollectionId = audioCollectionId;
        }
    }
}
